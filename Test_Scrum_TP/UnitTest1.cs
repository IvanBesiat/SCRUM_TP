using Scrum_TP;

namespace Test_Scrum_TP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAchatCreation_CalculMontantCMD_Alcool()
        {
            Boisson boissonTest = new Boisson("Bière 33cl", 1.5,4.5,20,0);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(boissonTest,1);
            Achat_Manager createAchat = new Achat_Manager(boissonList);

            double montantCMD = createAchat.CalculMontantCMD();

            Assert.AreEqual(montantCMD, 1.5);
        }
        [TestMethod]
        public void TestAchatCreation_CalculMontantCMD_Soft()
        {
            Boisson boissonTest = new Boisson("Coca 33cl", 0.6, 4.5, 10, 0);
            Dictionary<Boisson,int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(boissonTest,1);
            Achat_Manager createAchat = new Achat_Manager(boissonList);
            
            double montantCMD = createAchat.CalculMontantCMD();

            Assert.AreEqual(montantCMD, 0.6);
        }
        [TestMethod]
        public void TestAchatCreation_CalculMontantCMD_SoftPlusAlcool()
        {
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 0);
            Boisson softTest = new Boisson("Coca 33cl", 0.6, 4.5, 10, 0);
            Dictionary<Boisson,int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest,1);
            boissonList.Add(softTest,2);
            Achat_Manager createAchat = new Achat_Manager(boissonList);

            double montantCMD = createAchat.CalculMontantCMD();

            Assert.AreEqual(montantCMD, 2.7);
        }

        [TestMethod]
        public void TestAchatCreation_AguementerStock_SoftPlusAlcool()
        {
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 0);
            Boisson softTest = new Boisson("Coca 33cl", 0.6, 4.5, 10, 0);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest, 1);
            boissonList.Add(softTest, 2);
            Achat_Manager createAchat = new Achat_Manager(boissonList);

            string resultValue = createAchat.AuguementerStockBoisson();
            string resultAttendu = string.Format("Le nouveau stock de {0} est de {1} unité(s).Le nouveau stock de {2} est de {3} unité(s).","Bière 33cl", 1, "Coca 33cl", 2);

            Assert.AreEqual(resultAttendu, resultValue);
        }
    }
}