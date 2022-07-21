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

        [TestMethod]
        public void TestVenteCreation()
        {
            Vente_Manager vente_Manager = new Vente_Manager();
            double caisse = 100 ;
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 2);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest, 1);
            int quantite = 1;
            caisse = vente_Manager.CreationVente(boissonList, quantite);
            Assert.AreEqual(caisse, 104,5);  
        }

        [TestMethod]
        public void TestVenteRetirer()
        {
            Vente_Manager vente_Manager = new Vente_Manager();
            double caisse = 100;
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 2);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest, 1);
            int quantite = 1;
            caisse = vente_Manager.RetirerVente(boissonList, quantite);
            Assert.AreEqual(caisse,95,5);
        }

        [TestMethod]
        public void TestRetirerQuantite()
        {
            Vente_Manager vente_Manager = new Vente_Manager();
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 2);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest, 1);
            int quantite = 1;
            quantite = vente_Manager.RetirerQuantite(boissonList, quantite);
            Assert.AreEqual(quantite,1);
        }

        [TestMethod]
        public void TestAjouterQuantite()
        {
            Vente_Manager vente_Manager = new Vente_Manager();
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 2);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest, 1);
            int quantite = 1;
            quantite = vente_Manager.AjouterQuantite(boissonList, quantite);
            Assert.AreEqual(quantite, 3);
        }



    }
}