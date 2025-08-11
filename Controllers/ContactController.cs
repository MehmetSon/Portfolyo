using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;
using System.Net;
using System.Net.Mail;

namespace Portfolyo.Controllers
{
	public class ContactController : Controller
	{
		MyPortfolioContext myPortfolioContext = new MyPortfolioContext();

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SubmitForm(Contact model)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var fromAddress = model.Email;  // Gönderen e-posta adresi
					var toAddress = "mehmett.kabakk@hotmail.com";  // Alıcı e-posta adresi
					string subject = model.Title;  // Başlık
					string body =model.Description;  // E-posta mesajı

					var smtp = new SmtpClient
					{
						Host = "smtp.office365.com",  // SMTP sunucusu
						Port = 587, // SMTP portu (genellikle 587)
						EnableSsl = true, // SSL etkin
						Credentials = new NetworkCredential(fromAddress, model.Adress)  // Kendi e-posta şifrenizi buraya yazın
					};

					smtp.Send(fromAddress, toAddress, subject, body);  // E-posta gönderme
					ViewBag.Message = "Message sent successfully!";
				}
				catch (Exception ex)
				{
					// Hata mesajını yakalama
					ViewBag.Message = $"There was an error sending the message: {ex.Message}";
				}
			}
			return RedirectToAction("Index");
		}
	}
}
