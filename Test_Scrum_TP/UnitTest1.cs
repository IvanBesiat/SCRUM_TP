using Scrum_TP;

namespace Test_Scrum_TP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAchatCreation_CalculMontantCMD_Alcool()
        {
            Achat_Manager createAchat = new Achat_Manager();
            Boisson boissonTest = new Boisson("Bière 33cl", 1.5,4.5,20,0);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(boissonTest,1);

            double montantCMD = createAchat.CalculMontantCMD(boissonList);

            Assert.AreEqual(montantCMD, 1.5);
        }
        [TestMethod]
        public void TestAchatCreation_CalculMontantCMD_Soft()
        {
            Achat_Manager createAchat = new Achat_Manager();
            Boisson boissonTest = new Boisson("Coca 33cl", 0.6, 4.5, 20, 0);
            Dictionary<Boisson,int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(boissonTest,1);

            double montantCMD = createAchat.CalculMontantCMD(boissonList);

            Assert.AreEqual(montantCMD, 0.6);
        }
        [TestMethod]
        public void TestAchatCreation_CalculMontantCMD_SoftPlusAlcool()
        {
            Achat_Manager createAchat = new Achat_Manager();
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 0);
            Boisson softTest = new Boisson("Coca 33cl", 0.6, 4.5, 20, 0);
            Dictionary<Boisson,int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest,1);
            boissonList.Add(softTest,2);
            
            double montantCMD = createAchat.CalculMontantCMD(boissonList);

            Assert.AreEqual(montantCMD, 2.7);
        }
    }
}