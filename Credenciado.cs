using OpenQA.Selenium;
using System.Threading;

namespace MeuVale.I.Fwcard.Credenciado
{
    public class Credenciado
    {
        public IWebElement Edi { get; set; }
        public IWebElement Exportacao { get; set; }
        public IWebElement ExportacaoArquivo { get; set; }
        public IWebElement Nome { get; set; }
        public IWebElement Tipo { get; set; }
        public IWebElement Pesquisa { get; set; }
        public IWebElement Agendar { get; set; }
        public IWebElement Todos { get; set; }
        public IWebElement Status { get; set; }
        public IWebElement Produto { get; set; }

        public IWebElement BaixarArquivo { get; set; }

        public Credenciado()
        {
        }
        public void Autenticar(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://online.fwcard.com.br/fwcard/f?p=130:100");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("P100_USERNAME")).SendKeys("RODRIGO");
            driver.FindElement(By.Id("P100_PASSWORD")).SendKeys("99588Digo@");
            var entrar = driver.FindElement(By.Id("LOGIN"));
            entrar.Click();
        }

        public void AbaExportacao(IWebDriver driver)
        {
            this.Edi = driver.FindElement(By.XPath("//*[@id='jqmenu-4']/span/span[2]"));
            this.Edi.Click();
            this.Exportacao = driver.FindElement(By.XPath("//*[@id='P0_MENU_4_DISPLAY']/div/ul/li[3]/a"));
            this.Exportacao.Click();
            this.ExportacaoArquivo = driver.FindElement(By.XPath("//*[@id='P0_MENU_4_DISPLAY']/div/ul/li[3]/ul/li[2]/a"));
            this.ExportacaoArquivo.Click();
            this.Nome = driver.FindElement(By.XPath("//*[@id='15757409829179669']/tbody/tr[7]/td[1]/a/img"));
            this.Nome.Click();
        }
        public void Enviar(IWebDriver driver)
        {
            this.Pesquisa = driver.FindElement(By.Id("Pesquisar"));
            this.Pesquisa.Click();
            this.Agendar = driver.FindElement(By.XPath("//*[@id='OPCOES']/span"));
            this.Agendar.Click();
            this.Todos = driver.FindElement(By.XPath("//*[@id='OPCOES_MENU']/li[2]/a"));
            this.Todos.Click();
            Thread.Sleep(500);
            this.BaixarArquivo = driver.FindElement(By.XPath("//*[@id='button-1006-btnIconEl']"));
            this.BaixarArquivo.Click();
            Thread.Sleep(2000);
        }
        public void Carajas(IWebDriver driver)
        {
            this.Autenticar(driver);
            this.AbaExportacao(driver);
            this.Tipo = driver.FindElement(By.XPath("//*[@id='16574910867284711']/tbody/tr[2]/td[1]/a/img"));
            this.Tipo.Click();
            driver.FindElement(By.Id("P6540_ESTADO_CREDENCIADO")).SendKeys("APROVADO");
            driver.FindElement(By.Id("P6540_PRODUTO")).SendKeys("MV ADTO SALARIAL - ELDORADO DO CARAJÁS - PARÁ");
            Thread.Sleep(2000);
            this.Enviar(driver);
        }
        public void Santa(IWebDriver driver)
        {
            this.AbaExportacao(driver);
            this.Tipo = driver.FindElement(By.XPath("//*[@id='16574910867284711']/tbody/tr[3]/td[1]/a/img"));
            this.Tipo.Click();
            driver.FindElement(By.Id("P6540_ESTADO_CREDENCIADO")).SendKeys("APROVADO");
            driver.FindElement(By.Id("P6540_PRODUTO")).SendKeys("MV ADTO SALARIAL - STA IZABEL - PARÁ");
            Thread.Sleep(2000);
            this.Enviar(driver);
        }
        public void Refeicao(IWebDriver driver)
        {
            this.AbaExportacao(driver);
            this.Tipo = driver.FindElement(By.XPath("//*[@id='16574910867284711']/tbody/tr[4]/td[1]/a/img"));
            this.Tipo.Click();
            driver.FindElement(By.Id("P6540_ESTADO_CREDENCIADO")).SendKeys("APROVADO");
            driver.FindElement(By.Id("P6540_PRODUTO")).SendKeys("MV REFEIÇÃO");
            Thread.Sleep(2000);
            this.Enviar(driver);
        }
        public void BeneficioCombustivel(IWebDriver driver)
        {
            this.AbaExportacao(driver);
            this.Tipo = driver.FindElement(By.XPath("//*[@id='16574910867284711']/tbody/tr[5]/td[1]/a/img"));
            this.Tipo.Click();
            driver.FindElement(By.Id("P6540_ESTADO_CREDENCIADO")).SendKeys("APROVADO");
            driver.FindElement(By.Id("P6540_PRODUTO")).SendKeys("MV BENF COMBUSTÍVEL");
            Thread.Sleep(2000);
            this.Enviar(driver);
        }
        public void Alimentacao(IWebDriver driver)
        {
            this.AbaExportacao(driver);
            this.Tipo = driver.FindElement(By.XPath("//*[@id='16574910867284711']/tbody/tr[6]/td[1]/a/img"));
            this.Tipo.Click();
            driver.FindElement(By.Id("P6540_ESTADO_CREDENCIADO")).SendKeys("APROVADO");
            driver.FindElement(By.Id("P6540_PRODUTO")).SendKeys("MV ALIMENTAÇÃO");
            Thread.Sleep(2000);
            this.Enviar(driver);
        }
        public void Adiantamento(IWebDriver driver)
        {
            this.AbaExportacao(driver);
            this.Tipo = driver.FindElement(By.XPath("//*[@id='16574910867284711']/tbody/tr[8]/td[1]/a/img"));
            this.Tipo.Click();
            driver.FindElement(By.Id("P6540_ESTADO_CREDENCIADO")).SendKeys("APROVADO");
            driver.FindElement(By.Id("P6540_PRODUTO")).SendKeys("MV ADTO SALARIAL");
            Thread.Sleep(2000);
            this.Enviar(driver);
        }
        public void Farmacia(IWebDriver driver)
        {
            this.AbaExportacao(driver);
            this.Tipo = driver.FindElement(By.XPath("//*[@id='16574910867284711']/tbody/tr[9]/td[1]/a/img"));
            this.Tipo.Click();
            driver.FindElement(By.Id("P6540_ESTADO_CREDENCIADO")).SendKeys("APROVADO");
            driver.FindElement(By.Id("P6540_PRODUTO")).SendKeys("MV FARMÁCIA");
            Thread.Sleep(2000);
            this.Enviar(driver);
        }
        public void Convenio(IWebDriver driver)
        {
            this.AbaExportacao(driver);
            this.Tipo = driver.FindElement(By.XPath("//*[@id='16574910867284711']/tbody/tr[10]/td[1]/a/img"));
            this.Tipo.Click();
            driver.FindElement(By.Id("P6540_ESTADO_CREDENCIADO")).SendKeys("APROVADO");
            driver.FindElement(By.Id("P6540_PRODUTO")).SendKeys("MV CONV. COMBUSTÍVEL");
            Thread.Sleep(2000);
            this.Enviar(driver);
        }
    }
}
