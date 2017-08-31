using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMe.Forms
{
    public partial class FM_PrintInvoices : Form
    {
        SqliteHandler sql = new SqliteHandler();
        DataTable _dt_invoice = new DataTable();
        List<string> _client_data = new List<string>();
        List<string> _invoice_data = new List<string>();

        public FM_PrintInvoices()
        {
            InitializeComponent();
            cb_clientID.DataSource = sql.columnReturnData(FM_LoginScreen.conString, "ClientTable", "ClientID");
            SetInvoiceTable();
            SetClientInfoList();

        }
        private void FM_PrintInvoices_FormClosed(object sender, FormClosedEventArgs e)
        {
            FM_MainMenu mainmenu = new FM_MainMenu();
            mainmenu.Show();
        }

        private void SetInvoiceTable()
        {
            _dt_invoice = sql.FilterDataTable(FM_LoginScreen.conString, "InvoiceTable", cb_clientID.Text);
            List<string> invoiceID = new List<string>();
            if (_dt_invoice.Rows.Count == 0) { cb_invoiceNo.DataSource = new List<string>(); ClearInvoiceInfo(); return; }
            for (int dtrows = 0; dtrows < _dt_invoice.Rows.Count; dtrows++)
            {
                invoiceID.Add(Convert.ToString(_dt_invoice.Rows[dtrows][0]));
            }
            //Debug.WriteLine("invoiceID cound = " + invoiceID.Count);
            cb_invoiceNo.DataSource = invoiceID;
            SetInvoiceinfo();
        }

        private void ClearInvoiceInfo()
        {
            lb_invoicedate.Text = lb_invoicedescription.Text = lb_amount.Text = lb_invoiceduedate.Text = cb_invoiceNo.Text = "";
        }
        private void SetInvoiceinfo()
        {
            _invoice_data = new List<string>();
            for (int invoiceinfo = 0; invoiceinfo < _dt_invoice.Columns.Count; invoiceinfo++)
            {              
                _invoice_data.Add(Convert.ToString(_dt_invoice.Rows[cb_invoiceNo.SelectedIndex][invoiceinfo]));
            }
        }
        private void SetClientInfoList()
        {
            _client_data = sql.FillForm(FM_LoginScreen.conString, "ClientTable", cb_clientID.Text);
            FillForm();
        }
        private void cb_clientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetClientInfoList();
            SetInvoiceTable();
            FillForm();
        }
        private void cb_invoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetInvoiceinfo();
            FillForm();
        }
        private void FillForm()
        {
            //Update client info
            lb_clientaddress.Text = lb_clientcontact.Text = "";
            lb_clientname.Text = _client_data[1];
            for (int i = 2; i < 6; i++)
            {
                if (_client_data[i] == "null") { _client_data[i] = ""; }
                lb_clientaddress.Text += _client_data[i] + "\n";
            }
            for (int i = 6; i < 9; i++)
            {
                if (_client_data[i] == "null") { _client_data[i] = ""; }
                lb_clientcontact.Text += _client_data[i] + "\n";
            }
            //Update invoice info
            if (cb_invoiceNo.Text == "") { ClearInvoiceInfo(); return; }
            lb_amount.Text = "£" + Convert.ToString(_invoice_data[2]);
            lb_invoicedescription.Text = _invoice_data[3];
            lb_invoicedate.Text = _invoice_data[4];
            lb_invoiceduedate.Text = Convert.ToDateTime(_invoice_data[4]).AddDays(5).ToShortDateString();

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;

            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            DialogResult result = printDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        // Create PrintLayout
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // declaire instances and variables 
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            Font smallHeaderFont = new Font("Courier New", 10);
            Font titleFont = new Font("Courier New", 20);
            Font payableFont = new Font("Courier New", 17);
            Font TermsNcons = new Font("Courier New", 8);
            SolidBrush brushWhiteSmoke = new SolidBrush(Color.WhiteSmoke);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush brushGray = new SolidBrush(Color.Gray);
            Pen penBlack = new Pen(Color.Black);

            float fontHeight = font.GetHeight();
            int startX = e.MarginBounds.Left;
            int startY = e.MarginBounds.Top; 
            int headerHeight = 105;
            int offset = 10 + startY;
           
            #region Company Info (Note : maybe move to parms file
            // Create a Prams file for company info?
            string company = "Company Name";
            List<string> companyInfo = new List<string>();
            companyInfo.Add("addr1"); // address line 1
            companyInfo.Add("city"); // address line 2
            companyInfo.Add("addr2"); // city
            companyInfo.Add("Pcode");  // post code
            List<string> companyContact = new List<string>();
            companyContact.Add("name"); // contact name
            companyContact.Add("tel: "); // contact tel
            companyContact.Add("mob: "); // contact mob
            companyContact.Add("email"); // email
            #endregion
            // header 
            #region Header

            graphic.FillRectangle(brushWhiteSmoke, startX, startY, e.MarginBounds.Width, headerHeight);
            graphic.DrawString(company.PadRight(20), new Font("Courier New", 14), blackBrush, e.MarginBounds.Width / 2, startY + 5);
            offset = offset + (int)font.GetHeight();
            int i = 0;
            foreach (string s in companyInfo)
            {
                graphic.DrawString(s.PadRight(20) + companyContact[i], font, blackBrush, e.MarginBounds.Width / 2, offset);
                i++;
                offset = offset + (int)font.GetHeight();
            }
            graphic.DrawString("Invoice", titleFont, blackBrush, startX + 10, startY + headerHeight / 3);
            // End of 'Header'

            #endregion
            offset = offset + 50; // offset adds whitespace between header and ClientInfo

            // client details, invoice no + due date           
            #region Client Information, invoiceNo + due date
            // Bill To           
            graphic.DrawString("Bill To", smallHeaderFont, brushGray, startX,  offset);
            offset = offset + (int)font.GetHeight() + ((int)font.GetHeight() / 2);

            graphic.DrawString(lb_clientname.Text, font, blackBrush, startX, offset);
            offset = offset + (int)font.GetHeight();

            graphic.DrawString(lb_clientaddress.Text, font, blackBrush, startX,  offset);
            offset = offset + (int)font.GetHeight() * 5;
            // End of Bill To
            // Invoice small column
            headerHeight = headerHeight + 45 + startY; // use headerHeight for second column due to offset being set from first column

            graphic.DrawString("Invoice Number", smallHeaderFont, brushGray, e.MarginBounds.Width / 2, headerHeight);
            headerHeight = headerHeight + (int)font.GetHeight() + ((int)font.GetHeight() / 2);

            graphic.DrawString(cb_invoiceNo.Text, font, blackBrush, e.MarginBounds.Width / 2, headerHeight);
            headerHeight = offset - (int)(font.GetHeight() * 3.5);

            graphic.DrawString("Invoice Due", smallHeaderFont, brushGray, e.MarginBounds.Width / 2, headerHeight);
            headerHeight = headerHeight + (int)font.GetHeight() + ((int)font.GetHeight() / 2);

            graphic.DrawString(lb_invoiceduedate.Text, font, blackBrush, e.MarginBounds.Width / 2, headerHeight);
            headerHeight = headerHeight + (int)font.GetHeight();
            // End of Invoice small column
            #endregion
            offset = offset + 20; // add offset here to increase white space between client info and table

            // Top Section of Table + Postions for Verticals
            #region Column Headers + Creation of Divider Postions
            int xBoxOffset = 10;
            int RectHeight = 10; // Added Height for Rectangel ( Start Postions will need to be RectHieght/2 )
            int RectWidth = 20; // Added width for Rectangle ( start Postions will need to be RectWidth/2 )
            graphic.FillRectangle(brushWhiteSmoke, startX, offset - RectHeight / 2, e.MarginBounds.Width, font.GetHeight() + RectHeight);
            
            graphic.DrawRectangle(penBlack, startX, offset - RectHeight/2, (int)graphic.MeasureString("Units", font).Width + RectWidth, font.GetHeight() + RectHeight);
            graphic.DrawString("Units", font, brushGray, startX + xBoxOffset, offset);
            int endOfUnit = xBoxOffset = xBoxOffset + (int)graphic.MeasureString("Units", font).Width + RectWidth;
            endOfUnit = startX + endOfUnit - RectWidth / 2; // get start point for draw line

            graphic.DrawRectangle(penBlack, startX + xBoxOffset - RectWidth / 2, offset - RectHeight / 2, (int)graphic.MeasureString("Description", font).Width + RectWidth*6, font.GetHeight() + RectHeight);
            graphic.DrawString("Description", font, brushGray, startX + xBoxOffset + (int)(RectWidth*2.5), offset);
            int endOfDescription = xBoxOffset = xBoxOffset + (int)graphic.MeasureString("Description", font).Width + RectWidth*6;
            endOfDescription = startX + endOfDescription - RectWidth / 2; // get start point for draw line

            graphic.DrawRectangle(penBlack, startX + xBoxOffset - RectWidth/2, /*startY +*/  offset - RectHeight / 2, (int)graphic.MeasureString("Cost", font).Width + (int)(RectWidth*1.5), font.GetHeight() + RectHeight);
            graphic.DrawString("Cost", font, brushGray, startX + xBoxOffset + (int)(RectWidth/3), offset);
            int endOfCost = xBoxOffset = xBoxOffset + (int)graphic.MeasureString("Cost", font).Width + (int)(RectWidth * 1.5);
            endOfCost = startX + endOfCost - RectWidth / 2; // get start point for draw line

            graphic.DrawRectangle(penBlack, startX + xBoxOffset - RectWidth/2, offset - RectHeight / 2, (int)graphic.MeasureString("Total", font).Width + (int)(RectWidth*1.5), font.GetHeight() + RectHeight);
            graphic.DrawString("Total", font, brushGray, startX + xBoxOffset + (int)(RectWidth / 3), offset);
            int endOfTotal =xBoxOffset = xBoxOffset + (int)graphic.MeasureString("Total", font).Width + (int)(RectWidth*1.5);
            endOfTotal = startX + endOfTotal - RectWidth / 2; // get start point for draw line

            graphic.DrawRectangle(penBlack, startX + xBoxOffset - RectWidth / 2, offset - RectHeight / 2, e.MarginBounds.Right - (startX + xBoxOffset - RectWidth / 2), font.GetHeight() + RectHeight);
            graphic.DrawString("Grand Total", font, brushGray, (startX + xBoxOffset - RectWidth / 2) + ((e.MarginBounds.Right - (startX + xBoxOffset - RectWidth / 2) - (int)(graphic.MeasureString("Grand Total",font).Width)) /2), offset);
            
            offset = offset + RectHeight/2;  // set offset just after rectangles 
            int dividerLinesY = offset;
            #endregion
            // adding to offset here will increase white space between headers and the first table entry
            
            // Produce 'NumberOf' 'Item' 'CostPU' 'TotalCost' from InvoiceDescription
            #region Invoice Description ( Main Table )
            string[] splitDescription = lb_invoicedescription.Text.Replace(System.Environment.NewLine, "\n").Split('\n');
            offset = offset + 40; // set offset for first string
            double grTotal = 0; // declaire grand total variable
            foreach (string s in splitDescription)
            {
                string unit = s.Split('@')[0].Substring(0, s.IndexOf(" "));
                int unitWidth = (int)graphic.MeasureString(unit, font).Width;
                graphic.DrawString(unit, font, blackBrush, startX + (endOfUnit - startX)/2 - unitWidth/2, offset);

                string description = s.Split('@')[0].Substring(s.IndexOf(" ") + 1);
                int descriptionWidth = (int)graphic.MeasureString(description, font).Width;
                graphic.DrawString(description, font, blackBrush, endOfUnit + (endOfDescription - endOfUnit) / 2 - descriptionWidth / 2, offset);

                string cost = s.Split('@')[1].Split('=')[0].TrimStart(' ');
                int costWidth = (int)graphic.MeasureString(cost, font).Width;
                graphic.DrawString(cost, font, blackBrush, endOfDescription + (endOfCost - endOfDescription) / 2 - costWidth / 2, offset);

                string total = s.Split('@')[1].Split('=')[1].TrimStart(' ');
                int totalWidth = (int)graphic.MeasureString(total, font).Width;
                graphic.DrawString(total, font, blackBrush, endOfCost + (endOfTotal - endOfCost) / 2 - totalWidth / 2, offset);

                double gTotal;
                Double.TryParse(total.TrimStart('£'), out gTotal);
                
                grTotal = grTotal + gTotal;

                string grandTotal = "£" + String.Format("{0:0.00}", grTotal);
                int grandTotalWidth = (int)graphic.MeasureString(grandTotal, font).Width;
                graphic.DrawString(grandTotal, font, blackBrush, endOfTotal + (e.MarginBounds.Right - endOfTotal) / 2 - grandTotalWidth /2 , offset);

                offset = offset + 40;
            }
            #endregion
            offset = offset + 30; // add offset here to increase white space between last table entry and Bottom section of table 'payable section'

            //Draw Vertical Lines
            #region Vertical tableLines
            // Draw Vertical lines to form dividers use offset for height and dividerLinesY for start Y coords
            graphic.DrawLine(penBlack, startX, dividerLinesY, startX, offset);
            graphic.DrawLine(penBlack, endOfUnit, dividerLinesY, endOfUnit, offset);
            graphic.DrawLine(penBlack, endOfDescription, dividerLinesY, endOfDescription, offset);
            graphic.DrawLine(penBlack, endOfCost, dividerLinesY, endOfCost, offset);
            graphic.DrawLine(penBlack, endOfTotal, dividerLinesY, endOfTotal, offset);
            graphic.DrawLine(penBlack, e.MarginBounds.Right, dividerLinesY, e.MarginBounds.Right, offset);
            #endregion

            //Draw Bottom Section
            #region Button of Table ( Payable section )
            graphic.FillRectangle(brushWhiteSmoke, startX, offset, e.MarginBounds.Right - startX, 60);
            graphic.DrawRectangle(penBlack, startX, offset, e.MarginBounds.Right - startX, 60);
            graphic.DrawLine(penBlack, startX, offset + 50, e.MarginBounds.Right, offset + 50);
            string payable = "Total Payable is £" + String.Format("{0:0.00}", grTotal);
            graphic.DrawString(payable, payableFont, blackBrush, startX + (e.MarginBounds.Right - startX) /2 - graphic.MeasureString(payable, payableFont).Width/2 , offset + (int)payableFont.GetHeight() / 2);

            offset = offset + 60; // set offset to end of table
            #endregion
            offset = offset + 30; // add offset here to increase white space after end of table

            //Terms and conditions ( offset is set by page margin )
            #region Terms and Conditiins
            int termsNconsHeight = 3; // number of terms and conditions lines 
            offset = e.MarginBounds.Bottom - (int)TermsNcons.GetHeight() * (termsNconsHeight + 1); 
            graphic.DrawString("Terms and conditions", TermsNcons, brushGray, startX, offset);
            offset = offset + (int)TermsNcons.GetHeight();
            graphic.DrawString("Line1", TermsNcons, brushGray, startX, offset);
            offset = offset + (int)TermsNcons.GetHeight();
            graphic.DrawString("Line2", TermsNcons, brushGray, startX, offset);
            offset = offset + (int)TermsNcons.GetHeight();
            graphic.DrawString("Line3", TermsNcons, brushGray, startX, offset);
            offset = offset + (int)TermsNcons.GetHeight();
            #endregion
        }
    }
}
