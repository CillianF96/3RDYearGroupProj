using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using BusinessLayer;
using System.Runtime.InteropServices;
using QRCoder;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Mime;
using System.Drawing.Printing;
using BusinessEntities;
//using static System.Net.Mime.MediaTypeNames;
//using MailKit.Net.Smtp;
//using MailKit;
//using SmtpClient = MailKit.Net.Smtp.SmtpClient;
//using MimeKit;
//using SmptClient;

namespace ProductTracking
{
    public partial class formKey : Form
    {
        IModel Model;
        IRoomReservation Client;
        public formKey(IModel _model,IRoomReservation guestInfo)
        {
            InitializeComponent();
            Model = _model;
            Client = guestInfo;
        }

        private void btnKeySend_Click(object sender, EventArgs e)
        {
            string bookingNO;
            string checkOutDate;
            if (Client == null)
            {
                bookingNO = "five";
                checkOutDate = "01/01/2023";
                MessageBox.Show("Client is null");
            }
            else
            {
                bookingNO = Client.BookingNumber.ToString();
                checkOutDate = Client.CheckOutDate.ToString();
                MessageBox.Show("Client is populated");
            }


           
            string recipientEmail;
           Bitmap bmp = GenerateQrCode(bookingNO,checkOutDate);
            pcbKeyCode.Image = bmp;
            if (Client == null)
            {
                recipientEmail = "patrickmjdavis@gmail.com"; // Change this to the recipient's email address

            }
            else
            {
                recipientEmail=Client.Person.Email;
            }

           // SendEmailWithQRCode(recipientEmail, bmp);

          

        }
        ///make a button patrick that generates the qr code to print

        private void printDocumentKey_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           Bitmap btmp = new Bitmap(pcbKeyCode.Width, pcbKeyCode.Height);
            pcbKeyCode.DrawToBitmap(btmp,new Rectangle(0,0,pcbKeyCode.Width,pcbKeyCode.Height));
            e.Graphics.DrawImage(btmp,0,0);
            btmp.Dispose();
        }
        private Bitmap GenerateQrCode(string bookingNo,string date)
        {
            string fullQr = bookingNo + date;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(fullQr, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            return qrCodeImage;
        }
        private void SendEmailWithQRCode(string recipientEmail, Bitmap qrCodeImage)
        {



            try
            {
                string fromEmail = "consolatiohotel@outlook.com";
                string password = "college2023";
                string to = recipientEmail;
                string subject = "Your QR Code";
                string body = "<h1>Hello World!</h1>";

                string host = "smtp.office365.com";
                int port = 587;

                using (MailMessage mail = new MailMessage(fromEmail, to, subject, body))
                {
                    qrCodeImage.Save("qrcode.png");

                    mail.IsBodyHtml = true;
                    mail.Body = "Room Key Qr Code";
                    Attachment attachment = new Attachment("qrcode.png");
                    mail.Attachments.Add(attachment);

                    using (SmtpClient smtpClient = new SmtpClient(host, port))
                    {
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.EnableSsl = true;
                        smtpClient.Credentials = new NetworkCredential(fromEmail, password);

                        smtpClient.Send(mail);
                        MessageBox.Show("Email sent");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//end of function

        private void btnKeyClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
