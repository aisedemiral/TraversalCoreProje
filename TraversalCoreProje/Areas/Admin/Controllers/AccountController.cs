using BusinessLayer.Abstract.AbstractUow;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers;
[Area("Admin")]
[AllowAnonymous]
public class AccountController : Controller
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(AccountViewModel model)
    {
        var valuesSender = _accountService.TGetByID(model.SenderID);
        var valuesReceiver = _accountService.TGetByID(model.ReceiverID);

        valuesSender.Balance -= model.Amount;
        valuesReceiver.Balance += model.Amount;
        List<Account> modifiedAccounts = new List<Account>()
        {
            valuesSender,
            valuesReceiver
        };
            _accountService.TMultiUpdate(modifiedAccounts);
        return View();
    }
}