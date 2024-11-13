using Microsoft.AspNetCore.Mvc;

namespace WebApplicationlLab9.Controllers
{
    public class Lab9FedorchukController : Controller
    {
        public IActionResult FirstViewMethod()
        {
            List<String> vegetables = GetVegetablesList();
            return View(vegetables);
        }

        public List<String> GetVegetablesList() 
        {
            List<String> vegetables = new List<String>();
            vegetables.Add("Помідор");
            vegetables.Add("Огірок");
            vegetables.Add("Картопля");
            vegetables.Add("Баклажан");
            vegetables.Add("Кабачок");
            vegetables.Add("Капуста");
            vegetables.Add("Броколі");
            vegetables.Add("Квасоля");
            vegetables.Add("Перець");
            return vegetables;
        }
    }
}
