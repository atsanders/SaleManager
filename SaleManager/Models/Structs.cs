


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace SaleManager.db {
	
        /// <summary>
        /// Table: sqlite_sequence
        /// Primary Key: 
        /// </summary>

        public class sqlite_sequenceTable: DatabaseTable {
            
            public sqlite_sequenceTable(IDataProvider provider):base("sqlite_sequence",provider){
                ClassName = "sqlite_sequence";
                SchemaName = "";
                

                Columns.Add(new DatabaseColumn("name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2147483647
                });

                Columns.Add(new DatabaseColumn("seq", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2147483647
                });
                    
                
                
            }

            public IColumn name{
                get{
                    return this.GetColumn("name");
                }
            }
				
   			public static string nameColumn{
			      get{
        			return "name";
      			}
		    }
            
            public IColumn seq{
                get{
                    return this.GetColumn("seq");
                }
            }
				
   			public static string seqColumn{
			      get{
        			return "seq";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Sale
        /// Primary Key: id
        /// </summary>

        public class SaleTable: DatabaseTable {
            
            public SaleTable(IDataProvider provider):base("Sale",provider){
                ClassName = "Sale";
                SchemaName = "";
                

                Columns.Add(new DatabaseColumn("id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("startDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("endDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });
                    
                
                
            }

            public IColumn id{
                get{
                    return this.GetColumn("id");
                }
            }
				
   			public static string idColumn{
			      get{
        			return "id";
      			}
		    }
            
            public IColumn startDate{
                get{
                    return this.GetColumn("startDate");
                }
            }
				
   			public static string startDateColumn{
			      get{
        			return "startDate";
      			}
		    }
            
            public IColumn endDate{
                get{
                    return this.GetColumn("endDate");
                }
            }
				
   			public static string endDateColumn{
			      get{
        			return "endDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Order
        /// Primary Key: id
        /// </summary>

        public class OrderTable: DatabaseTable {
            
            public OrderTable(IDataProvider provider):base("Order",provider){
                ClassName = "Order";
                SchemaName = "";
                

                Columns.Add(new DatabaseColumn("id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("saleId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("number", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("complete", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("total", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });
                    
                
                
            }

            public IColumn id{
                get{
                    return this.GetColumn("id");
                }
            }
				
   			public static string idColumn{
			      get{
        			return "id";
      			}
		    }
            
            public IColumn saleId{
                get{
                    return this.GetColumn("saleId");
                }
            }
				
   			public static string saleIdColumn{
			      get{
        			return "saleId";
      			}
		    }
            
            public IColumn number{
                get{
                    return this.GetColumn("number");
                }
            }
				
   			public static string numberColumn{
			      get{
        			return "number";
      			}
		    }
            
            public IColumn complete{
                get{
                    return this.GetColumn("complete");
                }
            }
				
   			public static string completeColumn{
			      get{
        			return "complete";
      			}
		    }
            
            public IColumn total{
                get{
                    return this.GetColumn("total");
                }
            }
				
   			public static string totalColumn{
			      get{
        			return "total";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Sellers
        /// Primary Key: id
        /// </summary>

        public class SellersTable: DatabaseTable {
            
            public SellersTable(IDataProvider provider):base("Sellers",provider){
                ClassName = "Seller";
                SchemaName = "";
                

                Columns.Add(new DatabaseColumn("id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });
                    
                
                
            }

            public IColumn id{
                get{
                    return this.GetColumn("id");
                }
            }
				
   			public static string idColumn{
			      get{
        			return "id";
      			}
		    }
            
            public IColumn name{
                get{
                    return this.GetColumn("name");
                }
            }
				
   			public static string nameColumn{
			      get{
        			return "name";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: StartCash
        /// Primary Key: id
        /// </summary>

        public class StartCashTable: DatabaseTable {
            
            public StartCashTable(IDataProvider provider):base("StartCash",provider){
                ClassName = "StartCash";
                SchemaName = "";
                

                Columns.Add(new DatabaseColumn("id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("sellerId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("saleId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("cashAmount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });
                    
                
                
            }

            public IColumn id{
                get{
                    return this.GetColumn("id");
                }
            }
				
   			public static string idColumn{
			      get{
        			return "id";
      			}
		    }
            
            public IColumn sellerId{
                get{
                    return this.GetColumn("sellerId");
                }
            }
				
   			public static string sellerIdColumn{
			      get{
        			return "sellerId";
      			}
		    }
            
            public IColumn saleId{
                get{
                    return this.GetColumn("saleId");
                }
            }
				
   			public static string saleIdColumn{
			      get{
        			return "saleId";
      			}
		    }
            
            public IColumn cashAmount{
                get{
                    return this.GetColumn("cashAmount");
                }
            }
				
   			public static string cashAmountColumn{
			      get{
        			return "cashAmount";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: OrderItem
        /// Primary Key: id
        /// </summary>

        public class OrderItemTable: DatabaseTable {
            
            public OrderItemTable(IDataProvider provider):base("OrderItem",provider){
                ClassName = "OrderItem";
                SchemaName = "";
                

                Columns.Add(new DatabaseColumn("id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("orderId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("sellerId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("price", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2147483647
                });
                    
                
                
            }

            public IColumn id{
                get{
                    return this.GetColumn("id");
                }
            }
				
   			public static string idColumn{
			      get{
        			return "id";
      			}
		    }
            
            public IColumn orderId{
                get{
                    return this.GetColumn("orderId");
                }
            }
				
   			public static string orderIdColumn{
			      get{
        			return "orderId";
      			}
		    }
            
            public IColumn sellerId{
                get{
                    return this.GetColumn("sellerId");
                }
            }
				
   			public static string sellerIdColumn{
			      get{
        			return "sellerId";
      			}
		    }
            
            public IColumn price{
                get{
                    return this.GetColumn("price");
                }
            }
				
   			public static string priceColumn{
			      get{
        			return "price";
      			}
		    }
            
            public IColumn description{
                get{
                    return this.GetColumn("description");
                }
            }
				
   			public static string descriptionColumn{
			      get{
        			return "description";
      			}
		    }
            
                    
        }
        
}