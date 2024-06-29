namespace DotnetBenchmark
{
    public static class PerformanceTests
    {
        private static readonly Random random = new();

        private static readonly string loremIpsum = "Azure, plateforme cloud, offre solutions évolutives, services informatiques, stockage données, puissance calcul, intelligence artificielle, bases données, développement applications, sécurité avancée, intégration systèmes, analyses big data, apprentissage machine, conteneurs, Kubernetes, DevOps, gestion identités, réseaux virtuels, passerelles VPN, ExpressRoute, Azure Active Directory, IoT, services cognitifs, bots, blockchain, gestion API, automatisation, Machine Learning Studio, Visual Studio, GitHub, Power BI, Azure DevOps, réplication données, sauvegarde, reprise après sinistre, Azure Monitor, Log Analytics, sécurité réseau, pare-feu, Azure Sentinel, confidentialité données, conformité, certifications, Azure Marketplace, architectures hybrides, cloud public, cloud privé, scalabilité, flexibilité, performances, efficacité, innovation, transformation numérique, migration cloud, coûts opérationnels, paiement à l'usage, déploiement rapide, gestion ressources, templates ARM, Azure Functions, serverless, bases données SQL, Cosmos DB, stockage Blob, File Storage, Disk Storage, Azure Search, analyse stream, Event Hubs, Service Bus, Logic Apps, Azure Maps, Visual Studio Code, SDK Azure, CLI Azure, PowerShell, Azure Policy, gestion coûts, Azure Advisor, sécurité information, gestion risques, chiffrement, authentification multifacteur, confidential computing, Azure Sphere, développement durable, centres données verts, énergie renouvelable, Azure Quantum, réalité mixte, Azure Digital Twins, intelligence spatiale, Azure Synapse Analytics, Data Lake, Azure Databricks, intégration données, Azure Purview, gouvernance données, Azure Arc, gestion multicloud, Azure Stack, edge computing, 5G, réseaux définis par logiciel, Azure Front Door, CDN, Azure Media Services, streaming vidéo, Azure Communication Services, collaboration, Azure Health Bot, solutions santé, Azure Government, secteur public, Azure for Operators, télécommunications, Azure PlayFab, jeux vidéo, Azure Orbital, traitement satellite, Azure Migration Program, FastTrack for Azure, partenaires, écosystème, innovation ouverte, apprentissage profond, modèles pré-entraînés, personnalisation, expérience utilisateur, agilité, résilience, optimisation coûts, scalabilité globale, déploiement mondial, Azure App Service, web apps, mobile apps, API apps, Logic Apps, intégration entreprise, Azure Kubernetes Service, orchestration conteneurs, microservices, Azure Red Hat OpenShift, entreprises, développement agile, pipelines CI/CD, Azure Test Plans, qualité logicielle, Azure Artifacts, gestion packages, Azure Repos, contrôle version, collaboration code, Azure Boards, planification projet, suivi travail, Azure Monitor, insights applications, diagnostics, Azure Security Center, posture sécurité, Azure Key Vault, gestion secrets, Azure Information Protection, protection informations, Azure Backup, sauvegarde cloud, Azure Site Recovery, DRaaS, Azure SQL Database, base données managée, Azure Database for MySQL, PostgreSQL, MariaDB, Azure Cache for Redis, performance applications, Azure Application Gateway, équilibrage charge, Azure Load Balancer, haute disponibilité, Azure Traffic Manager, routage trafic, Azure ExpressRoute, connexion privée, Azure VPN Gateway, connectivité sécurisée, Azure Virtual WAN, réseau étendu, Azure Firewall, sécurité réseau centralisée, Azure Bastion, accès sécurisé, Azure Sentinel, SIEM, Azure Lighthouse, gestion à grande échelle, Azure Cost Management, optimisation dépenses, Azure Policy, conformité, Azure Blueprints, architectures référence, Azure Resource Manager, déploiement ressources, Azure Logic Apps, automatisation workflows, Azure Event Grid, événements cloud, Azure Service Fabric, microservices stateful, Azure Batch, calcul haute performance, Azure Machine Learning, création modèles ML, Azure Cognitive Services, intelligence artificielle accessible, Azure Bot Services, développement bots, Azure Blockchain Service, création applications blockchain, Azure IoT Hub, connectivité IoT, Azure Digital Twins, jumeaux";

        // je créé une liste de 100000 elements, puis je la trie
        public static void ListSorting()
        {
            var list = PrepareList();

            list.Sort();
        }

        // je créé deux matrices de taille 500x500 et je les multiplie
        public static void SquareMatrixMultiplication()
        {
            var matrix1 = GenerateRandomMatrix();
            var matrix2 = GenerateRandomMatrix();

            MatrixMultiplication(matrix1, matrix2);
        }

        // je fais des opérations sur une string
        public static void StringOperations()
        {
            loremIpsum.Split(' ');

            loremIpsum.Substring(loremIpsum.LastIndexOf("jumeaux"));

            loremIpsum.Replace("Azure", "LGTheBest");

            loremIpsum.ToLower();

            loremIpsum.ToUpper();
        }

        private static List<double> PrepareList()
        {
            const int listSize = 100000;

            return Enumerable.Range(0, listSize)
                        .Select(r => random.NextDouble())
                        .ToList();
        }

        private static double[,] GenerateRandomMatrix()
        {
            const int matrixSize = 500;

            var matrix = new double[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = random.NextDouble();
                }
            }

            return matrix;
        }

        private static double[,] MatrixMultiplication(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.Length != matrix2.Length)
            {
                throw new ArgumentException("The matrices must be of equal size");
            }

            if (matrix1.GetLength(0) != matrix1.GetLength(1) || matrix2.GetLength(0) != matrix2.GetLength(1))
            {
                throw new ArgumentException("The matrices must be square");
            }

            int matrixSize = matrix2.GetLength(0);

            var result = new double[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    result[i, j] = 0;

                    for (int k = 0; k < matrixSize; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }
    }
}