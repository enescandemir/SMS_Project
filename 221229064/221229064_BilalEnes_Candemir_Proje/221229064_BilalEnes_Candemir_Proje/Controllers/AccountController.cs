using _221229064_BilalEnes_Candemir_Proje.Concrete;
using _221229064_BilalEnes_Candemir_Proje.Entitites;
using Microsoft.AspNetCore.Mvc;

namespace _221229064_BilalEnes_Candemir_Proje.Controllers
{
	public class AccountController : Controller
	{
		public readonly SqlDbContext _context;

		public AccountController(SqlDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var accountList = _context.Accounts.ToList();
			return View(accountList);
		}


		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Create(Account account)
		{
			account.isActive = true;
			_context.Accounts.Add(account);
			_context.SaveChanges();
			return RedirectToAction("Index", "Account");
		}



		[HttpGet]
		public IActionResult Update()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Update(Account account)
		{
			var valueData = _context.Accounts.FirstOrDefault(x => x.Email == account.Email);
			if (valueData != null)
			{
				valueData.Password = account.Password;
				_context.Accounts.Update(valueData);
				_context.SaveChanges();
				return RedirectToAction("Index", "Account");
			}
			else
			{
				return View();
			}
		}

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(string email)
        {
            var account = _context.Accounts.FirstOrDefault(x => x.Email == email);

            if (account != null)
            {
                // Hesabı sil ve değişiklikleri kaydet
                _context.Accounts.Remove(account);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Account");
        }



    }
}

