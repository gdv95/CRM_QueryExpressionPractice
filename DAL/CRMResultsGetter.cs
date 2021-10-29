using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System.Net;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk.Query;

namespace DAL
{
    public class CRMResultsGetter
    {
        public static void getPhones()
        {
            QueryExpression systemUserQE = new QueryExpression
            {
                EntityName = "alv_phone",
                ColumnSet = new ColumnSet("alv_name"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        JoinOperator = JoinOperator.Inner,
                        LinkFromAttributeName = "alv_account",
                        LinkFromEntityName = "alv_phone",
                        LinkToAttributeName = "accountid",
                        LinkToEntityName = "account",
                        LinkCriteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression("accountnumber", ConditionOperator.Equal, "AAD-7821")
                            }
                        }
                    }
                }
            };

            try
            {
                DataCollection<Entity> systemUserEC = CRMProviderNew.getConnection().RetrieveMultiple(systemUserQE).Entities;
                foreach (Entity suE in systemUserEC)
                {
                    Console.WriteLine(suE.Attributes["alv_name"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void getName()
        {
            QueryExpression systemUserQE = new QueryExpression
            {
                EntityName = "account",
                ColumnSet = new ColumnSet("name"),
                Criteria =
                {
                    Conditions = {
                       new ConditionExpression("accountnumber", ConditionOperator.Equal, "AAD-7821")
                    }
                }
            };

            try
            {
                DataCollection<Entity> systemUserEC = CRMProviderNew.getConnection().RetrieveMultiple(systemUserQE).Entities;
                foreach (Entity suE in systemUserEC)
                {
                    Console.WriteLine(suE.Attributes["name"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void getClass()
        {
            QueryExpression systemUserQE = new QueryExpression
            {
                EntityName = "alv_class",
                ColumnSet = new ColumnSet("alv_name"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        JoinOperator = JoinOperator.Inner,
                        LinkFromAttributeName = "alv_classid",
                        LinkFromEntityName = "alv_class",
                        LinkToAttributeName = "alv_accountclass",
                        LinkToEntityName = "account",
                        LinkCriteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression("accountnumber", ConditionOperator.Equal, "AAD-7821")
                            }
                        }
                    }
                }
            };

            try
            {
                DataCollection<Entity> systemUserEC = CRMProviderNew.getConnection().RetrieveMultiple(systemUserQE).Entities;
                foreach (Entity suE in systemUserEC)
                {
                    Console.WriteLine(suE.Attributes["alv_name"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void getTerritory()
        {
            QueryExpression systemUserQE = new QueryExpression
            {
                EntityName = "territory",
                ColumnSet = new ColumnSet("name"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        JoinOperator = JoinOperator.Inner,
                        LinkFromAttributeName = "territoryid",
                        LinkFromEntityName = "territory",
                        LinkToAttributeName = "territoryid",
                        LinkToEntityName = "account",
                        LinkCriteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression("accountnumber", ConditionOperator.Equal, "AAD-7821")
                            }
                        }
                    }
                }
            };

            try
            {
                DataCollection<Entity> systemUserEC = CRMProviderNew.getConnection().RetrieveMultiple(systemUserQE).Entities;
                foreach (Entity suE in systemUserEC)
                {
                    Console.WriteLine(suE.Attributes["name"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void getParent()
        {
            QueryExpression systemUserQE = new QueryExpression
            {
                EntityName = "account",
                ColumnSet = new ColumnSet("name"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        JoinOperator = JoinOperator.Inner,
                        LinkFromAttributeName = "accountid",
                        LinkFromEntityName = "account",
                        LinkToAttributeName = "alv_parent",
                        LinkToEntityName = "account",
                        LinkCriteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression("accountnumber", ConditionOperator.Equal, "AAD-7821")
                            }
                        }
                    }
                }
            };

            try
            {
                DataCollection<Entity> systemUserEC = CRMProviderNew.getConnection().RetrieveMultiple(systemUserQE).Entities;
                foreach (Entity suE in systemUserEC)
                {
                    Console.WriteLine(suE.Attributes["name"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void getSNO()
        {
            QueryExpression systemUserQE = new QueryExpression
            {
                EntityName = "alv_taxtable",
                ColumnSet = new ColumnSet("alv_name"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        JoinOperator = JoinOperator.Inner,
                        LinkFromAttributeName = "alv_taxtableid",
                        LinkFromEntityName = "alv_taxtable",
                        LinkToAttributeName = "alv_sno",
                        LinkToEntityName = "account",
                        LinkCriteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression("accountnumber", ConditionOperator.Equal, "AAD-7821")
                            }
                        }
                    }
                }
            };

            try
            {
                DataCollection<Entity> systemUserEC = CRMProviderNew.getConnection().RetrieveMultiple(systemUserQE).Entities;
                foreach (Entity suE in systemUserEC)
                {
                    Console.WriteLine(suE.Attributes["alv_name"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void getAnalyticSPS()
        {
            QueryExpression systemUserQE = new QueryExpression
            {
                EntityName = "alv_analyticvalues",
                ColumnSet = new ColumnSet("alv_name"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        JoinOperator = JoinOperator.Inner,
                        LinkFromAttributeName = "alv_analyticvaluesid",
                        LinkFromEntityName = "alv_analyticvalues",
                        LinkToAttributeName = "alv_analityc_sps",
                        LinkToEntityName = "account",
                        LinkCriteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression("accountnumber", ConditionOperator.Equal, "AAD-7821")
                            }
                        }
                    }
                }
            };

            try
            {
                DataCollection<Entity> systemUserEC = CRMProviderNew.getConnection().RetrieveMultiple(systemUserQE).Entities;
                foreach (Entity suE in systemUserEC)
                {
                    Console.WriteLine(suE.Attributes["alv_name"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void getAnalyticSMI()
        {
            QueryExpression systemUserQE = new QueryExpression
            {
                EntityName = "alv_analyticvalues",
                ColumnSet = new ColumnSet("alv_name"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        JoinOperator = JoinOperator.Inner,
                        LinkFromAttributeName = "alv_analyticvaluesid",
                        LinkFromEntityName = "alv_analyticvalues",
                        LinkToAttributeName = "alv_analityc_depsmi",
                        LinkToEntityName = "account",
                        LinkCriteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression("accountnumber", ConditionOperator.Equal, "AAD-7821")
                            }
                        }
                    }
                }
            };

            try
            {
                DataCollection<Entity> systemUserEC = CRMProviderNew.getConnection().RetrieveMultiple(systemUserQE).Entities;
                foreach (Entity suE in systemUserEC)
                {
                    Console.WriteLine(suE.Attributes["alv_name"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void getAnalyticSbit()
        {
            QueryExpression systemUserQE = new QueryExpression
            {
                EntityName = "alv_analyticvalues",
                ColumnSet = new ColumnSet("alv_name"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        JoinOperator = JoinOperator.Inner,
                        LinkFromAttributeName = "alv_analyticvaluesid",
                        LinkFromEntityName = "alv_analyticvalues",
                        LinkToAttributeName = "alv_analityc_depsbit",
                        LinkToEntityName = "account",
                        LinkCriteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression("accountnumber", ConditionOperator.Equal, "AAD-7821")
                            }
                        }
                    }
                }
            };

            try
            {
                DataCollection<Entity> systemUserEC = CRMProviderNew.getConnection().RetrieveMultiple(systemUserQE).Entities;
                foreach (Entity suE in systemUserEC)
                {
                    Console.WriteLine(suE.Attributes["alv_name"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
