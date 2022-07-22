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
        public void TestVenteCreation_CreationVente_Alcool()
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
        public void TestVenteCreation_CreationVente_Soft()
        {
            Vente_Manager vente_Manager = new Vente_Manager();
            double caisse = 100;
            Boisson softTest = new Boisson("Coca 33cl", 0.6, 4.5, 10, 2);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(softTest, 1);
            int quantite = 1;
            caisse = vente_Manager.CreationVente(boissonList, quantite);
            Assert.AreEqual(caisse, 104, 5);
        }

        [TestMethod]
        public void TestVenteCreation_CreationVente_AlcoolPlusSoft()
        {
            Vente_Manager vente_Manager = new Vente_Manager();
            double caisse = 100;
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 2);
            Boisson softTest = new Boisson("Coca 33cl", 0.6, 4.5, 10, 2);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest, 1); 
            boissonList.Add(softTest, 2);
            int quantite = 1;
            caisse = vente_Manager.CreationVente(boissonList, quantite);
            Assert.AreEqual(caisse, 109);
        }


        [TestMethod]
        public void TestVenteRetirer_RetirerVente_Alcool_Soft()
        {
            Vente_Manager vente_Manager = new Vente_Manager();
            double caisse = 100;
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 2);
            Boisson softTest = new Boisson("Coca 33cl", 0.6, 4.5, 10, 2);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest, 1);
            int quantite = 1;
            caisse = vente_Manager.RetirerVente(boissonList, quantite);
            Assert.AreEqual(caisse,95,5);
        }

        [TestMethod]
        public void TestVenteRetirer_RetirerVente_Soft()
        {
            Vente_Manager vente_Manager = new Vente_Manager();
            double caisse = 100;
            Boisson softTest = new Boisson("Coca 33cl", 0.6, 4.5, 10,2);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(softTest, 1);
            int quantite = 1;
            caisse = vente_Manager.RetirerVente(boissonList, quantite);
            Assert.AreEqual(caisse, 95, 5);
        }

        [TestMethod]
        public void TestVenteRetirer_RetirerVente_Alcool()
        {
            Vente_Manager vente_Manager = new Vente_Manager();
            double caisse = 100;
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 2);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest, 1);
            int quantite = 1;
            caisse = vente_Manager.RetirerVente(boissonList, quantite);
            Assert.AreEqual(caisse, 95, 5);
        }

        [TestMethod]
        public void TestRetirerQuantite_AjouterVente()
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
        public void TestAjouterQuantite_RetirerVente()
        {
            Vente_Manager vente_Manager = new Vente_Manager();
            Boisson alcoolTest = new Boisson("Bière 33cl", 1.5, 4.5, 20, 2);
            Dictionary<Boisson, int> boissonList = new Dictionary<Boisson, int>();
            boissonList.Add(alcoolTest, 1);
            int quantite = 1;
            quantite = vente_Manager.AjouterQuantite(boissonList, quantite);
            Assert.AreEqual(quantite, 3);
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
            string resultAttendu = string.Format("Le nouveau stock de {0} est de {1} unite(s).Le nouveau stock de {2} est de {3} unite(s).","Bière 33cl", 1, "Coca 33cl", 2);

            Assert.AreEqual(resultAttendu, resultValue);
        }
    }
}