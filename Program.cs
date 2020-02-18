using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MeuVale.I.Fwcard.Credenciado
{
    class Program
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            var carajas = new Credenciado();
            carajas.Carajas(driver);

            var santa = new Credenciado();
            santa.Santa(driver);

            var refeicao = new Credenciado();
            refeicao.Refeicao(driver);

            var beneficioCombustivel = new Credenciado();
            beneficioCombustivel.BeneficioCombustivel(driver);

            var alimentacao = new Credenciado();
            alimentacao.Alimentacao(driver);

            var adiantamento = new Credenciado();
            adiantamento.Adiantamento(driver);

            var farmacia = new Credenciado();
            farmacia.Farmacia(driver);

            var convenio = new Credenciado();
            convenio.Convenio(driver);

            driver.Quit();
        }
    }
}


