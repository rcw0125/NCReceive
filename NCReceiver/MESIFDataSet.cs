namespace NCReceiver
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlSchemaProvider("GetTypedDataSetSchema"), DesignerCategory("code"), ToolboxItem(true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), XmlRoot("MESIFDataSet")]
    public class MESIFDataSet : DataSet
    {
        private System.Data.SchemaSerializationMode _schemaSerializationMode;
        private AlloyElementDataTable tableAlloyElement;
        private AlloyTransDataTable tableAlloyTrans;
        private BulkPurchaseDataTable tableBulkPurchase;
        private PlanOrderDataTable tablePlanOrder;
        private SteelMaterialWarehouseDataTable tableSteelMaterialWarehouse;
        private SteelTreasuryDataTable tableSteelTreasury;

        [DebuggerNonUserCode]
        public MESIFDataSet()
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.InitClass();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
        }

        [DebuggerNonUserCode]
        protected MESIFDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(info, context))
            {
                this.InitVars(false);
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
            else
            {
                string s = (string) info.GetValue("XmlSchema", typeof(string));
                if (base.DetermineSchemaSerializationMode(info, context) == System.Data.SchemaSerializationMode.IncludeSchema)
                {
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
                    if (dataSet.Tables["PlanOrder"] != null)
                    {
                        base.Tables.Add(new PlanOrderDataTable(dataSet.Tables["PlanOrder"]));
                    }
                    if (dataSet.Tables["BulkPurchase"] != null)
                    {
                        base.Tables.Add(new BulkPurchaseDataTable(dataSet.Tables["BulkPurchase"]));
                    }
                    if (dataSet.Tables["AlloyTrans"] != null)
                    {
                        base.Tables.Add(new AlloyTransDataTable(dataSet.Tables["AlloyTrans"]));
                    }
                    if (dataSet.Tables["SteelTreasury"] != null)
                    {
                        base.Tables.Add(new SteelTreasuryDataTable(dataSet.Tables["SteelTreasury"]));
                    }
                    if (dataSet.Tables["SteelMaterialWarehouse"] != null)
                    {
                        base.Tables.Add(new SteelMaterialWarehouseDataTable(dataSet.Tables["SteelMaterialWarehouse"]));
                    }
                    if (dataSet.Tables["AlloyElement"] != null)
                    {
                        base.Tables.Add(new AlloyElementDataTable(dataSet.Tables["AlloyElement"]));
                    }
                    base.DataSetName = dataSet.DataSetName;
                    base.Prefix = dataSet.Prefix;
                    base.Namespace = dataSet.Namespace;
                    base.Locale = dataSet.Locale;
                    base.CaseSensitive = dataSet.CaseSensitive;
                    base.EnforceConstraints = dataSet.EnforceConstraints;
                    base.Merge(dataSet, false, MissingSchemaAction.Add);
                    this.InitVars();
                }
                else
                {
                    base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
                }
                base.GetSerializationData(info, context);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.SchemaChanged);
                base.Tables.CollectionChanged += handler2;
                this.Relations.CollectionChanged += handler2;
            }
        }

        [DebuggerNonUserCode]
        public override DataSet Clone()
        {
            MESIFDataSet set = (MESIFDataSet) base.Clone();
            set.InitVars();
            set.SchemaSerializationMode = this.SchemaSerializationMode;
            return set;
        }

        [DebuggerNonUserCode]
        protected override XmlSchema GetSchemaSerializable()
        {
            MemoryStream w = new MemoryStream();
            base.WriteXmlSchema(new XmlTextWriter(w, null));
            w.Position = 0L;
            return XmlSchema.Read(new XmlTextReader(w), null);
        }

        [DebuggerNonUserCode]
        public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
        {
            MESIFDataSet set = new MESIFDataSet();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            xs.Add(set.GetSchemaSerializable());
            XmlSchemaAny item = new XmlSchemaAny();
            item.Namespace = set.Namespace;
            sequence.Items.Add(item);
            type.Particle = sequence;
            return type;
        }

        [DebuggerNonUserCode]
        private void InitClass()
        {
            base.DataSetName = "MESIFDataSet";
            base.Prefix = "";
            base.Namespace = "http://www.pzhsteel.com.cn/MESIFDataSet.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tablePlanOrder = new PlanOrderDataTable();
            base.Tables.Add(this.tablePlanOrder);
            this.tableBulkPurchase = new BulkPurchaseDataTable();
            base.Tables.Add(this.tableBulkPurchase);
            this.tableAlloyTrans = new AlloyTransDataTable();
            base.Tables.Add(this.tableAlloyTrans);
            this.tableSteelTreasury = new SteelTreasuryDataTable();
            base.Tables.Add(this.tableSteelTreasury);
            this.tableSteelMaterialWarehouse = new SteelMaterialWarehouseDataTable();
            base.Tables.Add(this.tableSteelMaterialWarehouse);
            this.tableAlloyElement = new AlloyElementDataTable();
            base.Tables.Add(this.tableAlloyElement);
        }

        [DebuggerNonUserCode]
        protected override void InitializeDerivedDataSet()
        {
            base.BeginInit();
            this.InitClass();
            base.EndInit();
        }

        [DebuggerNonUserCode]
        internal void InitVars()
        {
            this.InitVars(true);
        }

        [DebuggerNonUserCode]
        internal void InitVars(bool initTable)
        {
            this.tablePlanOrder = (PlanOrderDataTable) base.Tables["PlanOrder"];
            if (initTable && (this.tablePlanOrder != null))
            {
                this.tablePlanOrder.InitVars();
            }
            this.tableBulkPurchase = (BulkPurchaseDataTable) base.Tables["BulkPurchase"];
            if (initTable && (this.tableBulkPurchase != null))
            {
                this.tableBulkPurchase.InitVars();
            }
            this.tableAlloyTrans = (AlloyTransDataTable) base.Tables["AlloyTrans"];
            if (initTable && (this.tableAlloyTrans != null))
            {
                this.tableAlloyTrans.InitVars();
            }
            this.tableSteelTreasury = (SteelTreasuryDataTable) base.Tables["SteelTreasury"];
            if (initTable && (this.tableSteelTreasury != null))
            {
                this.tableSteelTreasury.InitVars();
            }
            this.tableSteelMaterialWarehouse = (SteelMaterialWarehouseDataTable) base.Tables["SteelMaterialWarehouse"];
            if (initTable && (this.tableSteelMaterialWarehouse != null))
            {
                this.tableSteelMaterialWarehouse.InitVars();
            }
            this.tableAlloyElement = (AlloyElementDataTable) base.Tables["AlloyElement"];
            if (initTable && (this.tableAlloyElement != null))
            {
                this.tableAlloyElement.InitVars();
            }
        }

        [DebuggerNonUserCode]
        protected override void ReadXmlSerializable(XmlReader reader)
        {
            if (base.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)
            {
                this.Reset();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);
                if (dataSet.Tables["PlanOrder"] != null)
                {
                    base.Tables.Add(new PlanOrderDataTable(dataSet.Tables["PlanOrder"]));
                }
                if (dataSet.Tables["BulkPurchase"] != null)
                {
                    base.Tables.Add(new BulkPurchaseDataTable(dataSet.Tables["BulkPurchase"]));
                }
                if (dataSet.Tables["AlloyTrans"] != null)
                {
                    base.Tables.Add(new AlloyTransDataTable(dataSet.Tables["AlloyTrans"]));
                }
                if (dataSet.Tables["SteelTreasury"] != null)
                {
                    base.Tables.Add(new SteelTreasuryDataTable(dataSet.Tables["SteelTreasury"]));
                }
                if (dataSet.Tables["SteelMaterialWarehouse"] != null)
                {
                    base.Tables.Add(new SteelMaterialWarehouseDataTable(dataSet.Tables["SteelMaterialWarehouse"]));
                }
                if (dataSet.Tables["AlloyElement"] != null)
                {
                    base.Tables.Add(new AlloyElementDataTable(dataSet.Tables["AlloyElement"]));
                }
                base.DataSetName = dataSet.DataSetName;
                base.Prefix = dataSet.Prefix;
                base.Namespace = dataSet.Namespace;
                base.Locale = dataSet.Locale;
                base.CaseSensitive = dataSet.CaseSensitive;
                base.EnforceConstraints = dataSet.EnforceConstraints;
                base.Merge(dataSet, false, MissingSchemaAction.Add);
                this.InitVars();
            }
            else
            {
                base.ReadXml(reader);
                this.InitVars();
            }
        }

        [DebuggerNonUserCode]
        private void SchemaChanged(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
            {
                this.InitVars();
            }
        }

        [DebuggerNonUserCode]
        private bool ShouldSerializeAlloyElement()
        {
            return false;
        }

        [DebuggerNonUserCode]
        private bool ShouldSerializeAlloyTrans()
        {
            return false;
        }

        [DebuggerNonUserCode]
        private bool ShouldSerializeBulkPurchase()
        {
            return false;
        }

        [DebuggerNonUserCode]
        private bool ShouldSerializePlanOrder()
        {
            return false;
        }

        [DebuggerNonUserCode]
        protected override bool ShouldSerializeRelations()
        {
            return false;
        }

        [DebuggerNonUserCode]
        private bool ShouldSerializeSteelMaterialWarehouse()
        {
            return false;
        }

        [DebuggerNonUserCode]
        private bool ShouldSerializeSteelTreasury()
        {
            return false;
        }

        [DebuggerNonUserCode]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AlloyElementDataTable AlloyElement
        {
            get
            {
                return this.tableAlloyElement;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode]
        public AlloyTransDataTable AlloyTrans
        {
            get
            {
                return this.tableAlloyTrans;
            }
        }

        [Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BulkPurchaseDataTable BulkPurchase
        {
            get
            {
                return this.tableBulkPurchase;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
        public PlanOrderDataTable PlanOrder
        {
            get
            {
                return this.tablePlanOrder;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
        public DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(true), DebuggerNonUserCode]
        public override System.Data.SchemaSerializationMode SchemaSerializationMode
        {
            get
            {
                return this._schemaSerializationMode;
            }
            set
            {
                this._schemaSerializationMode = value;
            }
        }

        [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SteelMaterialWarehouseDataTable SteelMaterialWarehouse
        {
            get
            {
                return this.tableSteelMaterialWarehouse;
            }
        }

        [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SteelTreasuryDataTable SteelTreasury
        {
            get
            {
                return this.tableSteelTreasury;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
        public DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class AlloyElementDataTable : DataTable, IEnumerable
        {
            private DataColumn columnAl;
            private DataColumn columnAlS;
            private DataColumn columnAs;
            private DataColumn columnB;
            private DataColumn columnbcompcheck;
            private DataColumn columnC;
            private DataColumn columnCa;
            private DataColumn columncbaseid;
            private DataColumn columnccheckbillid;
            private DataColumn columnCeq;
            private DataColumn columncpraycorp;
            private DataColumn columnCr;
            private DataColumn columncstoreorganization;
            private DataColumn columnCu;
            private DataColumn columnH;
            private DataColumn columnMn;
            private DataColumn columnMo;
            private DataColumn columnN;
            private DataColumn columnnassistchecknum;
            private DataColumn columnNb;
            private DataColumn columnNi;
            private DataColumn columnnnum;
            private DataColumn columnO;
            private DataColumn columnOther1;
            private DataColumn columnOther2;
            private DataColumn columnP;
            private DataColumn columnPb;
            private DataColumn columnRe;
            private DataColumn columnS;
            private DataColumn columnSb;
            private DataColumn columnSi;
            private DataColumn columnSn;
            private DataColumn columnTi;
            private DataColumn columnV;
            private DataColumn columnvcheckbillcode;
            private DataColumn columnvproductbatchcode;
            private DataColumn columnvsamplecode;
            private DataColumn columnW;
            private DataColumn columnZn;

            public event MESIFDataSet.AlloyElementRowChangeEventHandler AlloyElementRowChanged;

            public event MESIFDataSet.AlloyElementRowChangeEventHandler AlloyElementRowChanging;

            public event MESIFDataSet.AlloyElementRowChangeEventHandler AlloyElementRowDeleted;

            public event MESIFDataSet.AlloyElementRowChangeEventHandler AlloyElementRowDeleting;

            [DebuggerNonUserCode]
            public AlloyElementDataTable()
            {
                base.TableName = "AlloyElement";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode]
            internal AlloyElementDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            protected AlloyElementDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode]
            public void AddAlloyElementRow(MESIFDataSet.AlloyElementRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.AlloyElementRow AddAlloyElementRow(string vproductbatchcode, string vcheckbillcode, string bcompcheck, int nassistchecknum, string cstoreorganization, string cpraycorp, string ccheckbillid, string cbaseid, string vsamplecode, string nnum, double C, double Si, double Mn, double P, double S, double Cu, double Ni, double Cr, double Mo, double V, double Nb, double Al, double AlS, double Ti, double B, double Sb, double As, double Sn, double Zn, double Ca, double W, double Pb, double Re, double Ceq, double N, double H, double O, double Other1, double Other2)
            {
                MESIFDataSet.AlloyElementRow row = (MESIFDataSet.AlloyElementRow) base.NewRow();
                row.ItemArray = new object[] { 
                    vproductbatchcode, vcheckbillcode, bcompcheck, nassistchecknum, cstoreorganization, cpraycorp, ccheckbillid, cbaseid, vsamplecode, nnum, C, Si, Mn, P, S, Cu, 
                    Ni, Cr, Mo, V, Nb, Al, AlS, Ti, B, Sb, As, Sn, Zn, Ca, W, Pb, 
                    Re, Ceq, N, H, O, Other1, Other2
                 };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                MESIFDataSet.AlloyElementDataTable table = (MESIFDataSet.AlloyElementDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new MESIFDataSet.AlloyElementDataTable();
            }

            [DebuggerNonUserCode]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(MESIFDataSet.AlloyElementRow);
            }

            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                MESIFDataSet set = new MESIFDataSet();
                xs.Add(set.GetSchemaSerializable());
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = 1M;
                any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                attribute.Name = "namespace";
                attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "AlloyElementDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                return type;
            }

            [DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnvproductbatchcode = new DataColumn("vproductbatchcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnvproductbatchcode);
                this.columnvcheckbillcode = new DataColumn("vcheckbillcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnvcheckbillcode);
                this.columnbcompcheck = new DataColumn("bcompcheck", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnbcompcheck);
                this.columnnassistchecknum = new DataColumn("nassistchecknum", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnassistchecknum);
                this.columncstoreorganization = new DataColumn("cstoreorganization", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncstoreorganization);
                this.columncpraycorp = new DataColumn("cpraycorp", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncpraycorp);
                this.columnccheckbillid = new DataColumn("ccheckbillid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnccheckbillid);
                this.columncbaseid = new DataColumn("cbaseid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncbaseid);
                this.columnvsamplecode = new DataColumn("vsamplecode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnvsamplecode);
                this.columnnnum = new DataColumn("nnum", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnnum);
                this.columnC = new DataColumn("C", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnC);
                this.columnSi = new DataColumn("Si", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnSi);
                this.columnMn = new DataColumn("Mn", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnMn);
                this.columnP = new DataColumn("P", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnP);
                this.columnS = new DataColumn("S", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnS);
                this.columnCu = new DataColumn("Cu", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnCu);
                this.columnNi = new DataColumn("Ni", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnNi);
                this.columnCr = new DataColumn("Cr", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnCr);
                this.columnMo = new DataColumn("Mo", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnMo);
                this.columnV = new DataColumn("V", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnV);
                this.columnNb = new DataColumn("Nb", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnNb);
                this.columnAl = new DataColumn("Al", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnAl);
                this.columnAlS = new DataColumn("AlS", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnAlS);
                this.columnTi = new DataColumn("Ti", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnTi);
                this.columnB = new DataColumn("B", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnB);
                this.columnSb = new DataColumn("Sb", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnSb);
                this.columnAs = new DataColumn("As", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnAs);
                this.columnSn = new DataColumn("Sn", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnSn);
                this.columnZn = new DataColumn("Zn", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnZn);
                this.columnCa = new DataColumn("Ca", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnCa);
                this.columnW = new DataColumn("W", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnW);
                this.columnPb = new DataColumn("Pb", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnPb);
                this.columnRe = new DataColumn("Re", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnRe);
                this.columnCeq = new DataColumn("Ceq", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnCeq);
                this.columnN = new DataColumn("N", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnN);
                this.columnH = new DataColumn("H", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnH);
                this.columnO = new DataColumn("O", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnO);
                this.columnOther1 = new DataColumn("Other1", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnOther1);
                this.columnOther2 = new DataColumn("Other2", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnOther2);
                this.columnvproductbatchcode.MaxLength = 0xff;
                this.columnvcheckbillcode.MaxLength = 0xff;
                this.columnbcompcheck.MaxLength = 0xff;
                this.columncstoreorganization.MaxLength = 0xff;
                this.columncpraycorp.MaxLength = 0xff;
                this.columnccheckbillid.MaxLength = 0xff;
                this.columncbaseid.MaxLength = 0xff;
                this.columnvsamplecode.MaxLength = 0xff;
                this.columnnnum.MaxLength = 0xff;
            }

            [DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnvproductbatchcode = base.Columns["vproductbatchcode"];
                this.columnvcheckbillcode = base.Columns["vcheckbillcode"];
                this.columnbcompcheck = base.Columns["bcompcheck"];
                this.columnnassistchecknum = base.Columns["nassistchecknum"];
                this.columncstoreorganization = base.Columns["cstoreorganization"];
                this.columncpraycorp = base.Columns["cpraycorp"];
                this.columnccheckbillid = base.Columns["ccheckbillid"];
                this.columncbaseid = base.Columns["cbaseid"];
                this.columnvsamplecode = base.Columns["vsamplecode"];
                this.columnnnum = base.Columns["nnum"];
                this.columnC = base.Columns["C"];
                this.columnSi = base.Columns["Si"];
                this.columnMn = base.Columns["Mn"];
                this.columnP = base.Columns["P"];
                this.columnS = base.Columns["S"];
                this.columnCu = base.Columns["Cu"];
                this.columnNi = base.Columns["Ni"];
                this.columnCr = base.Columns["Cr"];
                this.columnMo = base.Columns["Mo"];
                this.columnV = base.Columns["V"];
                this.columnNb = base.Columns["Nb"];
                this.columnAl = base.Columns["Al"];
                this.columnAlS = base.Columns["AlS"];
                this.columnTi = base.Columns["Ti"];
                this.columnB = base.Columns["B"];
                this.columnSb = base.Columns["Sb"];
                this.columnAs = base.Columns["As"];
                this.columnSn = base.Columns["Sn"];
                this.columnZn = base.Columns["Zn"];
                this.columnCa = base.Columns["Ca"];
                this.columnW = base.Columns["W"];
                this.columnPb = base.Columns["Pb"];
                this.columnRe = base.Columns["Re"];
                this.columnCeq = base.Columns["Ceq"];
                this.columnN = base.Columns["N"];
                this.columnH = base.Columns["H"];
                this.columnO = base.Columns["O"];
                this.columnOther1 = base.Columns["Other1"];
                this.columnOther2 = base.Columns["Other2"];
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.AlloyElementRow NewAlloyElementRow()
            {
                return (MESIFDataSet.AlloyElementRow) base.NewRow();
            }

            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new MESIFDataSet.AlloyElementRow(builder);
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.AlloyElementRowChanged != null)
                {
                    this.AlloyElementRowChanged(this, new MESIFDataSet.AlloyElementRowChangeEvent((MESIFDataSet.AlloyElementRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.AlloyElementRowChanging != null)
                {
                    this.AlloyElementRowChanging(this, new MESIFDataSet.AlloyElementRowChangeEvent((MESIFDataSet.AlloyElementRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.AlloyElementRowDeleted != null)
                {
                    this.AlloyElementRowDeleted(this, new MESIFDataSet.AlloyElementRowChangeEvent((MESIFDataSet.AlloyElementRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.AlloyElementRowDeleting != null)
                {
                    this.AlloyElementRowDeleting(this, new MESIFDataSet.AlloyElementRowChangeEvent((MESIFDataSet.AlloyElementRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            public void RemoveAlloyElementRow(MESIFDataSet.AlloyElementRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode]
            public DataColumn AlColumn
            {
                get
                {
                    return this.columnAl;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn AlSColumn
            {
                get
                {
                    return this.columnAlS;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn AsColumn
            {
                get
                {
                    return this.columnAs;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn BColumn
            {
                get
                {
                    return this.columnB;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn bcompcheckColumn
            {
                get
                {
                    return this.columnbcompcheck;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn CaColumn
            {
                get
                {
                    return this.columnCa;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn cbaseidColumn
            {
                get
                {
                    return this.columncbaseid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn ccheckbillidColumn
            {
                get
                {
                    return this.columnccheckbillid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn CColumn
            {
                get
                {
                    return this.columnC;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn CeqColumn
            {
                get
                {
                    return this.columnCeq;
                }
            }

            [DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn cpraycorpColumn
            {
                get
                {
                    return this.columncpraycorp;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn CrColumn
            {
                get
                {
                    return this.columnCr;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn cstoreorganizationColumn
            {
                get
                {
                    return this.columncstoreorganization;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn CuColumn
            {
                get
                {
                    return this.columnCu;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn HColumn
            {
                get
                {
                    return this.columnH;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.AlloyElementRow this[int index]
            {
                get
                {
                    return (MESIFDataSet.AlloyElementRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode]
            public DataColumn MnColumn
            {
                get
                {
                    return this.columnMn;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn MoColumn
            {
                get
                {
                    return this.columnMo;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn nassistchecknumColumn
            {
                get
                {
                    return this.columnnassistchecknum;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn NbColumn
            {
                get
                {
                    return this.columnNb;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn NColumn
            {
                get
                {
                    return this.columnN;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn NiColumn
            {
                get
                {
                    return this.columnNi;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn nnumColumn
            {
                get
                {
                    return this.columnnnum;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn OColumn
            {
                get
                {
                    return this.columnO;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn Other1Column
            {
                get
                {
                    return this.columnOther1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn Other2Column
            {
                get
                {
                    return this.columnOther2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn PbColumn
            {
                get
                {
                    return this.columnPb;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn PColumn
            {
                get
                {
                    return this.columnP;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn ReColumn
            {
                get
                {
                    return this.columnRe;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn SbColumn
            {
                get
                {
                    return this.columnSb;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn SColumn
            {
                get
                {
                    return this.columnS;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn SiColumn
            {
                get
                {
                    return this.columnSi;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn SnColumn
            {
                get
                {
                    return this.columnSn;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn TiColumn
            {
                get
                {
                    return this.columnTi;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn vcheckbillcodeColumn
            {
                get
                {
                    return this.columnvcheckbillcode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn VColumn
            {
                get
                {
                    return this.columnV;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn vproductbatchcodeColumn
            {
                get
                {
                    return this.columnvproductbatchcode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn vsamplecodeColumn
            {
                get
                {
                    return this.columnvsamplecode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn WColumn
            {
                get
                {
                    return this.columnW;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn ZnColumn
            {
                get
                {
                    return this.columnZn;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class AlloyElementRow : DataRow
        {
            private MESIFDataSet.AlloyElementDataTable tableAlloyElement;

            [DebuggerNonUserCode]
            internal AlloyElementRow(DataRowBuilder rb) : base(rb)
            {
                this.tableAlloyElement = (MESIFDataSet.AlloyElementDataTable) base.Table;
            }

            [DebuggerNonUserCode]
            public bool IsAlNull()
            {
                return base.IsNull(this.tableAlloyElement.AlColumn);
            }

            [DebuggerNonUserCode]
            public bool IsAlSNull()
            {
                return base.IsNull(this.tableAlloyElement.AlSColumn);
            }

            [DebuggerNonUserCode]
            public bool IsAsNull()
            {
                return base.IsNull(this.tableAlloyElement.AsColumn);
            }

            [DebuggerNonUserCode]
            public bool IsbcompcheckNull()
            {
                return base.IsNull(this.tableAlloyElement.bcompcheckColumn);
            }

            [DebuggerNonUserCode]
            public bool IsBNull()
            {
                return base.IsNull(this.tableAlloyElement.BColumn);
            }

            [DebuggerNonUserCode]
            public bool IsCaNull()
            {
                return base.IsNull(this.tableAlloyElement.CaColumn);
            }

            [DebuggerNonUserCode]
            public bool IscbaseidNull()
            {
                return base.IsNull(this.tableAlloyElement.cbaseidColumn);
            }

            [DebuggerNonUserCode]
            public bool IsccheckbillidNull()
            {
                return base.IsNull(this.tableAlloyElement.ccheckbillidColumn);
            }

            [DebuggerNonUserCode]
            public bool IsCeqNull()
            {
                return base.IsNull(this.tableAlloyElement.CeqColumn);
            }

            [DebuggerNonUserCode]
            public bool IsCNull()
            {
                return base.IsNull(this.tableAlloyElement.CColumn);
            }

            [DebuggerNonUserCode]
            public bool IscpraycorpNull()
            {
                return base.IsNull(this.tableAlloyElement.cpraycorpColumn);
            }

            [DebuggerNonUserCode]
            public bool IsCrNull()
            {
                return base.IsNull(this.tableAlloyElement.CrColumn);
            }

            [DebuggerNonUserCode]
            public bool IscstoreorganizationNull()
            {
                return base.IsNull(this.tableAlloyElement.cstoreorganizationColumn);
            }

            [DebuggerNonUserCode]
            public bool IsCuNull()
            {
                return base.IsNull(this.tableAlloyElement.CuColumn);
            }

            [DebuggerNonUserCode]
            public bool IsHNull()
            {
                return base.IsNull(this.tableAlloyElement.HColumn);
            }

            [DebuggerNonUserCode]
            public bool IsMnNull()
            {
                return base.IsNull(this.tableAlloyElement.MnColumn);
            }

            [DebuggerNonUserCode]
            public bool IsMoNull()
            {
                return base.IsNull(this.tableAlloyElement.MoColumn);
            }

            [DebuggerNonUserCode]
            public bool IsnassistchecknumNull()
            {
                return base.IsNull(this.tableAlloyElement.nassistchecknumColumn);
            }

            [DebuggerNonUserCode]
            public bool IsNbNull()
            {
                return base.IsNull(this.tableAlloyElement.NbColumn);
            }

            [DebuggerNonUserCode]
            public bool IsNiNull()
            {
                return base.IsNull(this.tableAlloyElement.NiColumn);
            }

            [DebuggerNonUserCode]
            public bool IsNNull()
            {
                return base.IsNull(this.tableAlloyElement.NColumn);
            }

            [DebuggerNonUserCode]
            public bool IsnnumNull()
            {
                return base.IsNull(this.tableAlloyElement.nnumColumn);
            }

            [DebuggerNonUserCode]
            public bool IsONull()
            {
                return base.IsNull(this.tableAlloyElement.OColumn);
            }

            [DebuggerNonUserCode]
            public bool IsOther1Null()
            {
                return base.IsNull(this.tableAlloyElement.Other1Column);
            }

            [DebuggerNonUserCode]
            public bool IsOther2Null()
            {
                return base.IsNull(this.tableAlloyElement.Other2Column);
            }

            [DebuggerNonUserCode]
            public bool IsPbNull()
            {
                return base.IsNull(this.tableAlloyElement.PbColumn);
            }

            [DebuggerNonUserCode]
            public bool IsPNull()
            {
                return base.IsNull(this.tableAlloyElement.PColumn);
            }

            [DebuggerNonUserCode]
            public bool IsReNull()
            {
                return base.IsNull(this.tableAlloyElement.ReColumn);
            }

            [DebuggerNonUserCode]
            public bool IsSbNull()
            {
                return base.IsNull(this.tableAlloyElement.SbColumn);
            }

            [DebuggerNonUserCode]
            public bool IsSiNull()
            {
                return base.IsNull(this.tableAlloyElement.SiColumn);
            }

            [DebuggerNonUserCode]
            public bool IsSnNull()
            {
                return base.IsNull(this.tableAlloyElement.SnColumn);
            }

            [DebuggerNonUserCode]
            public bool IsSNull()
            {
                return base.IsNull(this.tableAlloyElement.SColumn);
            }

            [DebuggerNonUserCode]
            public bool IsTiNull()
            {
                return base.IsNull(this.tableAlloyElement.TiColumn);
            }

            [DebuggerNonUserCode]
            public bool IsvcheckbillcodeNull()
            {
                return base.IsNull(this.tableAlloyElement.vcheckbillcodeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsVNull()
            {
                return base.IsNull(this.tableAlloyElement.VColumn);
            }

            [DebuggerNonUserCode]
            public bool IsvproductbatchcodeNull()
            {
                return base.IsNull(this.tableAlloyElement.vproductbatchcodeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsvsamplecodeNull()
            {
                return base.IsNull(this.tableAlloyElement.vsamplecodeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsWNull()
            {
                return base.IsNull(this.tableAlloyElement.WColumn);
            }

            [DebuggerNonUserCode]
            public bool IsZnNull()
            {
                return base.IsNull(this.tableAlloyElement.ZnColumn);
            }

            [DebuggerNonUserCode]
            public void SetAlNull()
            {
                base[this.tableAlloyElement.AlColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetAlSNull()
            {
                base[this.tableAlloyElement.AlSColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetAsNull()
            {
                base[this.tableAlloyElement.AsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetbcompcheckNull()
            {
                base[this.tableAlloyElement.bcompcheckColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetBNull()
            {
                base[this.tableAlloyElement.BColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetCaNull()
            {
                base[this.tableAlloyElement.CaColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetcbaseidNull()
            {
                base[this.tableAlloyElement.cbaseidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetccheckbillidNull()
            {
                base[this.tableAlloyElement.ccheckbillidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetCeqNull()
            {
                base[this.tableAlloyElement.CeqColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetCNull()
            {
                base[this.tableAlloyElement.CColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetcpraycorpNull()
            {
                base[this.tableAlloyElement.cpraycorpColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetCrNull()
            {
                base[this.tableAlloyElement.CrColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetcstoreorganizationNull()
            {
                base[this.tableAlloyElement.cstoreorganizationColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetCuNull()
            {
                base[this.tableAlloyElement.CuColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetHNull()
            {
                base[this.tableAlloyElement.HColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetMnNull()
            {
                base[this.tableAlloyElement.MnColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetMoNull()
            {
                base[this.tableAlloyElement.MoColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetnassistchecknumNull()
            {
                base[this.tableAlloyElement.nassistchecknumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetNbNull()
            {
                base[this.tableAlloyElement.NbColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetNiNull()
            {
                base[this.tableAlloyElement.NiColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetNNull()
            {
                base[this.tableAlloyElement.NColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetnnumNull()
            {
                base[this.tableAlloyElement.nnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetONull()
            {
                base[this.tableAlloyElement.OColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetOther1Null()
            {
                base[this.tableAlloyElement.Other1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetOther2Null()
            {
                base[this.tableAlloyElement.Other2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetPbNull()
            {
                base[this.tableAlloyElement.PbColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetPNull()
            {
                base[this.tableAlloyElement.PColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetReNull()
            {
                base[this.tableAlloyElement.ReColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetSbNull()
            {
                base[this.tableAlloyElement.SbColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetSiNull()
            {
                base[this.tableAlloyElement.SiColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetSnNull()
            {
                base[this.tableAlloyElement.SnColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetSNull()
            {
                base[this.tableAlloyElement.SColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetTiNull()
            {
                base[this.tableAlloyElement.TiColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetvcheckbillcodeNull()
            {
                base[this.tableAlloyElement.vcheckbillcodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetVNull()
            {
                base[this.tableAlloyElement.VColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetvproductbatchcodeNull()
            {
                base[this.tableAlloyElement.vproductbatchcodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetvsamplecodeNull()
            {
                base[this.tableAlloyElement.vsamplecodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetWNull()
            {
                base[this.tableAlloyElement.WColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetZnNull()
            {
                base[this.tableAlloyElement.ZnColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public double Al
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.AlColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Al”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.AlColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double AlS
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.AlSColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“AlS”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.AlSColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double As
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.AsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“As”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.AsColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double B
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.BColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“B”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.BColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string bcompcheck
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyElement.bcompcheckColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“bcompcheck”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyElement.bcompcheckColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double C
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.CColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“C”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.CColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Ca
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.CaColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Ca”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.CaColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string cbaseid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyElement.cbaseidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“cbaseid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyElement.cbaseidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string ccheckbillid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyElement.ccheckbillidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“ccheckbillid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyElement.ccheckbillidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Ceq
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.CeqColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Ceq”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.CeqColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string cpraycorp
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyElement.cpraycorpColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“cpraycorp”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyElement.cpraycorpColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Cr
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.CrColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Cr”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.CrColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string cstoreorganization
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyElement.cstoreorganizationColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“cstoreorganization”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyElement.cstoreorganizationColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Cu
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.CuColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Cu”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.CuColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double H
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.HColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“H”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.HColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Mn
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.MnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Mn”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.MnColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Mo
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.MoColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Mo”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.MoColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double N
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.NColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“N”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.NColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public int nassistchecknum
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tableAlloyElement.nassistchecknumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“nassistchecknum”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.nassistchecknumColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Nb
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.NbColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Nb”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.NbColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Ni
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.NiColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Ni”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.NiColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string nnum
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyElement.nnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“nnum”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyElement.nnumColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double O
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.OColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“O”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.OColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Other1
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.Other1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Other1”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.Other1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Other2
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.Other2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Other2”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.Other2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public double P
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.PColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“P”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.PColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Pb
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.PbColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Pb”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.PbColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Re
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.ReColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Re”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.ReColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double S
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.SColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“S”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.SColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Sb
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.SbColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Sb”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.SbColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Si
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.SiColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Si”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.SiColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Sn
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.SnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Sn”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.SnColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Ti
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.TiColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Ti”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.TiColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double V
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.VColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“V”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.VColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string vcheckbillcode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyElement.vcheckbillcodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“vcheckbillcode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyElement.vcheckbillcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string vproductbatchcode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyElement.vproductbatchcodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“vproductbatchcode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyElement.vproductbatchcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string vsamplecode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyElement.vsamplecodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“vsamplecode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyElement.vsamplecodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double W
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.WColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“W”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.WColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double Zn
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyElement.ZnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyElement”中列“Zn”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyElement.ZnColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class AlloyElementRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private MESIFDataSet.AlloyElementRow eventRow;

            [DebuggerNonUserCode]
            public AlloyElementRowChangeEvent(MESIFDataSet.AlloyElementRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.AlloyElementRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        public delegate void AlloyElementRowChangeEventHandler(object sender, MESIFDataSet.AlloyElementRowChangeEvent e);

        [Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
        public class AlloyTransDataTable : DataTable, IEnumerable
        {
            private DataColumn columncinventoryid;
            private DataColumn columncinwarehouseid;
            private DataColumn columncoutwarehouseid;
            private DataColumn columndbilldate;
            private DataColumn columninvcode;
            private DataColumn columninvname;
            private DataColumn columninvspec;
            private DataColumn columninvtype;
            private DataColumn columnnassistnum;
            private DataColumn columnnnum;
            private DataColumn columnpk_corp;
            private DataColumn columnvproductbatchcode;
            private DataColumn columnzdy1;
            private DataColumn columnzdy2;
            private DataColumn columnzdy3;
            private DataColumn columnzdy4;
            private DataColumn columnzdy5;
            private DataColumn columnzyx1;
            private DataColumn columnzyx2;
            private DataColumn columnzyx3;
            private DataColumn columnzyx4;
            private DataColumn columnzyx5;

            public event MESIFDataSet.AlloyTransRowChangeEventHandler AlloyTransRowChanged;

            public event MESIFDataSet.AlloyTransRowChangeEventHandler AlloyTransRowChanging;

            public event MESIFDataSet.AlloyTransRowChangeEventHandler AlloyTransRowDeleted;

            public event MESIFDataSet.AlloyTransRowChangeEventHandler AlloyTransRowDeleting;

            [DebuggerNonUserCode]
            public AlloyTransDataTable()
            {
                base.TableName = "AlloyTrans";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode]
            internal AlloyTransDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            protected AlloyTransDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode]
            public void AddAlloyTransRow(MESIFDataSet.AlloyTransRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.AlloyTransRow AddAlloyTransRow(string cinventoryid, string invcode, string invname, string invspec, string invtype, string dbilldate, string coutwarehouseid, string cinwarehouseid, double nnum, int nassistnum, string vproductbatchcode, string zdy1, string zdy2, string zdy3, string zdy4, string zdy5, string zyx1, string zyx2, string zyx3, string zyx4, string zyx5, string pk_corp)
            {
                MESIFDataSet.AlloyTransRow row = (MESIFDataSet.AlloyTransRow) base.NewRow();
                row.ItemArray = new object[] { 
                    cinventoryid, invcode, invname, invspec, invtype, dbilldate, coutwarehouseid, cinwarehouseid, nnum, nassistnum, vproductbatchcode, zdy1, zdy2, zdy3, zdy4, zdy5, 
                    zyx1, zyx2, zyx3, zyx4, zyx5, pk_corp
                 };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                MESIFDataSet.AlloyTransDataTable table = (MESIFDataSet.AlloyTransDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new MESIFDataSet.AlloyTransDataTable();
            }

            [DebuggerNonUserCode]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(MESIFDataSet.AlloyTransRow);
            }

            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                MESIFDataSet set = new MESIFDataSet();
                xs.Add(set.GetSchemaSerializable());
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = 1M;
                any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                attribute.Name = "namespace";
                attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "AlloyTransDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                return type;
            }

            [DebuggerNonUserCode]
            private void InitClass()
            {
                this.columncinventoryid = new DataColumn("cinventoryid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncinventoryid);
                this.columninvcode = new DataColumn("invcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvcode);
                this.columninvname = new DataColumn("invname", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvname);
                this.columninvspec = new DataColumn("invspec", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvspec);
                this.columninvtype = new DataColumn("invtype", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvtype);
                this.columndbilldate = new DataColumn("dbilldate", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndbilldate);
                this.columncoutwarehouseid = new DataColumn("coutwarehouseid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncoutwarehouseid);
                this.columncinwarehouseid = new DataColumn("cinwarehouseid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncinwarehouseid);
                this.columnnnum = new DataColumn("nnum", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnnnum);
                this.columnnassistnum = new DataColumn("nassistnum", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnassistnum);
                this.columnvproductbatchcode = new DataColumn("vproductbatchcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnvproductbatchcode);
                this.columnzdy1 = new DataColumn("zdy1", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy1);
                this.columnzdy2 = new DataColumn("zdy2", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy2);
                this.columnzdy3 = new DataColumn("zdy3", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy3);
                this.columnzdy4 = new DataColumn("zdy4", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy4);
                this.columnzdy5 = new DataColumn("zdy5", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy5);
                this.columnzyx1 = new DataColumn("zyx1", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx1);
                this.columnzyx2 = new DataColumn("zyx2", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx2);
                this.columnzyx3 = new DataColumn("zyx3", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx3);
                this.columnzyx4 = new DataColumn("zyx4", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx4);
                this.columnzyx5 = new DataColumn("zyx5", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx5);
                this.columnpk_corp = new DataColumn("pk_corp", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnpk_corp);
                base.Constraints.Add(new UniqueConstraint("AlloyTransKey1", new DataColumn[] { this.columncinventoryid }, false));
                this.columncinventoryid.Unique = true;
                this.columncinventoryid.MaxLength = 0xff;
                this.columninvcode.MaxLength = 0xff;
                this.columninvname.MaxLength = 0xff;
                this.columninvspec.MaxLength = 0xff;
                this.columninvtype.MaxLength = 0xff;
                this.columndbilldate.MaxLength = 0xff;
                this.columncoutwarehouseid.MaxLength = 0xff;
                this.columncinwarehouseid.MaxLength = 0xff;
                this.columnvproductbatchcode.MaxLength = 0xff;
                this.columnzdy1.MaxLength = 0xff;
                this.columnzdy2.MaxLength = 0xff;
                this.columnzdy3.MaxLength = 0xff;
                this.columnzdy4.MaxLength = 0xff;
                this.columnzdy5.MaxLength = 0xff;
                this.columnzyx1.MaxLength = 0xff;
                this.columnzyx2.MaxLength = 0xff;
                this.columnzyx3.MaxLength = 0xff;
                this.columnzyx4.MaxLength = 0xff;
                this.columnzyx5.MaxLength = 0xff;
                this.columnpk_corp.MaxLength = 0xff;
                base.Locale = new CultureInfo("zh-CN");
            }

            [DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columncinventoryid = base.Columns["cinventoryid"];
                this.columninvcode = base.Columns["invcode"];
                this.columninvname = base.Columns["invname"];
                this.columninvspec = base.Columns["invspec"];
                this.columninvtype = base.Columns["invtype"];
                this.columndbilldate = base.Columns["dbilldate"];
                this.columncoutwarehouseid = base.Columns["coutwarehouseid"];
                this.columncinwarehouseid = base.Columns["cinwarehouseid"];
                this.columnnnum = base.Columns["nnum"];
                this.columnnassistnum = base.Columns["nassistnum"];
                this.columnvproductbatchcode = base.Columns["vproductbatchcode"];
                this.columnzdy1 = base.Columns["zdy1"];
                this.columnzdy2 = base.Columns["zdy2"];
                this.columnzdy3 = base.Columns["zdy3"];
                this.columnzdy4 = base.Columns["zdy4"];
                this.columnzdy5 = base.Columns["zdy5"];
                this.columnzyx1 = base.Columns["zyx1"];
                this.columnzyx2 = base.Columns["zyx2"];
                this.columnzyx3 = base.Columns["zyx3"];
                this.columnzyx4 = base.Columns["zyx4"];
                this.columnzyx5 = base.Columns["zyx5"];
                this.columnpk_corp = base.Columns["pk_corp"];
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.AlloyTransRow NewAlloyTransRow()
            {
                return (MESIFDataSet.AlloyTransRow) base.NewRow();
            }

            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new MESIFDataSet.AlloyTransRow(builder);
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.AlloyTransRowChanged != null)
                {
                    this.AlloyTransRowChanged(this, new MESIFDataSet.AlloyTransRowChangeEvent((MESIFDataSet.AlloyTransRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.AlloyTransRowChanging != null)
                {
                    this.AlloyTransRowChanging(this, new MESIFDataSet.AlloyTransRowChangeEvent((MESIFDataSet.AlloyTransRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.AlloyTransRowDeleted != null)
                {
                    this.AlloyTransRowDeleted(this, new MESIFDataSet.AlloyTransRowChangeEvent((MESIFDataSet.AlloyTransRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.AlloyTransRowDeleting != null)
                {
                    this.AlloyTransRowDeleting(this, new MESIFDataSet.AlloyTransRowChangeEvent((MESIFDataSet.AlloyTransRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            public void RemoveAlloyTransRow(MESIFDataSet.AlloyTransRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode]
            public DataColumn cinventoryidColumn
            {
                get
                {
                    return this.columncinventoryid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn cinwarehouseidColumn
            {
                get
                {
                    return this.columncinwarehouseid;
                }
            }

            [DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn coutwarehouseidColumn
            {
                get
                {
                    return this.columncoutwarehouseid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn dbilldateColumn
            {
                get
                {
                    return this.columndbilldate;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invcodeColumn
            {
                get
                {
                    return this.columninvcode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invnameColumn
            {
                get
                {
                    return this.columninvname;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invspecColumn
            {
                get
                {
                    return this.columninvspec;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invtypeColumn
            {
                get
                {
                    return this.columninvtype;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.AlloyTransRow this[int index]
            {
                get
                {
                    return (MESIFDataSet.AlloyTransRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode]
            public DataColumn nassistnumColumn
            {
                get
                {
                    return this.columnnassistnum;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn nnumColumn
            {
                get
                {
                    return this.columnnnum;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn pk_corpColumn
            {
                get
                {
                    return this.columnpk_corp;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn vproductbatchcodeColumn
            {
                get
                {
                    return this.columnvproductbatchcode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy1Column
            {
                get
                {
                    return this.columnzdy1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy2Column
            {
                get
                {
                    return this.columnzdy2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy3Column
            {
                get
                {
                    return this.columnzdy3;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy4Column
            {
                get
                {
                    return this.columnzdy4;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy5Column
            {
                get
                {
                    return this.columnzdy5;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx1Column
            {
                get
                {
                    return this.columnzyx1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx2Column
            {
                get
                {
                    return this.columnzyx2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx3Column
            {
                get
                {
                    return this.columnzyx3;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx4Column
            {
                get
                {
                    return this.columnzyx4;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx5Column
            {
                get
                {
                    return this.columnzyx5;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class AlloyTransRow : DataRow
        {
            private MESIFDataSet.AlloyTransDataTable tableAlloyTrans;

            [DebuggerNonUserCode]
            internal AlloyTransRow(DataRowBuilder rb) : base(rb)
            {
                this.tableAlloyTrans = (MESIFDataSet.AlloyTransDataTable) base.Table;
            }

            [DebuggerNonUserCode]
            public bool IscinventoryidNull()
            {
                return base.IsNull(this.tableAlloyTrans.cinventoryidColumn);
            }

            [DebuggerNonUserCode]
            public bool IscinwarehouseidNull()
            {
                return base.IsNull(this.tableAlloyTrans.cinwarehouseidColumn);
            }

            [DebuggerNonUserCode]
            public bool IscoutwarehouseidNull()
            {
                return base.IsNull(this.tableAlloyTrans.coutwarehouseidColumn);
            }

            [DebuggerNonUserCode]
            public bool IsdbilldateNull()
            {
                return base.IsNull(this.tableAlloyTrans.dbilldateColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvcodeNull()
            {
                return base.IsNull(this.tableAlloyTrans.invcodeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvnameNull()
            {
                return base.IsNull(this.tableAlloyTrans.invnameColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvspecNull()
            {
                return base.IsNull(this.tableAlloyTrans.invspecColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvtypeNull()
            {
                return base.IsNull(this.tableAlloyTrans.invtypeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsnassistnumNull()
            {
                return base.IsNull(this.tableAlloyTrans.nassistnumColumn);
            }

            [DebuggerNonUserCode]
            public bool IsnnumNull()
            {
                return base.IsNull(this.tableAlloyTrans.nnumColumn);
            }

            [DebuggerNonUserCode]
            public bool Ispk_corpNull()
            {
                return base.IsNull(this.tableAlloyTrans.pk_corpColumn);
            }

            [DebuggerNonUserCode]
            public bool IsvproductbatchcodeNull()
            {
                return base.IsNull(this.tableAlloyTrans.vproductbatchcodeColumn);
            }

            [DebuggerNonUserCode]
            public bool Iszdy1Null()
            {
                return base.IsNull(this.tableAlloyTrans.zdy1Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy2Null()
            {
                return base.IsNull(this.tableAlloyTrans.zdy2Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy3Null()
            {
                return base.IsNull(this.tableAlloyTrans.zdy3Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy4Null()
            {
                return base.IsNull(this.tableAlloyTrans.zdy4Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy5Null()
            {
                return base.IsNull(this.tableAlloyTrans.zdy5Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx1Null()
            {
                return base.IsNull(this.tableAlloyTrans.zyx1Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx2Null()
            {
                return base.IsNull(this.tableAlloyTrans.zyx2Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx3Null()
            {
                return base.IsNull(this.tableAlloyTrans.zyx3Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx4Null()
            {
                return base.IsNull(this.tableAlloyTrans.zyx4Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx5Null()
            {
                return base.IsNull(this.tableAlloyTrans.zyx5Column);
            }

            [DebuggerNonUserCode]
            public void SetcinventoryidNull()
            {
                base[this.tableAlloyTrans.cinventoryidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetcinwarehouseidNull()
            {
                base[this.tableAlloyTrans.cinwarehouseidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetcoutwarehouseidNull()
            {
                base[this.tableAlloyTrans.coutwarehouseidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetdbilldateNull()
            {
                base[this.tableAlloyTrans.dbilldateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvcodeNull()
            {
                base[this.tableAlloyTrans.invcodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvnameNull()
            {
                base[this.tableAlloyTrans.invnameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvspecNull()
            {
                base[this.tableAlloyTrans.invspecColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvtypeNull()
            {
                base[this.tableAlloyTrans.invtypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetnassistnumNull()
            {
                base[this.tableAlloyTrans.nassistnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetnnumNull()
            {
                base[this.tableAlloyTrans.nnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setpk_corpNull()
            {
                base[this.tableAlloyTrans.pk_corpColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetvproductbatchcodeNull()
            {
                base[this.tableAlloyTrans.vproductbatchcodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy1Null()
            {
                base[this.tableAlloyTrans.zdy1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy2Null()
            {
                base[this.tableAlloyTrans.zdy2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy3Null()
            {
                base[this.tableAlloyTrans.zdy3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy4Null()
            {
                base[this.tableAlloyTrans.zdy4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy5Null()
            {
                base[this.tableAlloyTrans.zdy5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx1Null()
            {
                base[this.tableAlloyTrans.zyx1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx2Null()
            {
                base[this.tableAlloyTrans.zyx2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx3Null()
            {
                base[this.tableAlloyTrans.zyx3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx4Null()
            {
                base[this.tableAlloyTrans.zyx4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx5Null()
            {
                base[this.tableAlloyTrans.zyx5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public string cinventoryid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.cinventoryidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“cinventoryid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.cinventoryidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string cinwarehouseid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.cinwarehouseidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“cinwarehouseid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.cinwarehouseidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string coutwarehouseid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.coutwarehouseidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“coutwarehouseid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.coutwarehouseidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string dbilldate
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.dbilldateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“dbilldate”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.dbilldateColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invcode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.invcodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“invcode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.invcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invname
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.invnameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“invname”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.invnameColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invspec
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.invspecColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“invspec”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.invspecColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invtype
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.invtypeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“invtype”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.invtypeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public int nassistnum
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tableAlloyTrans.nassistnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“nassistnum”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyTrans.nassistnumColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double nnum
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableAlloyTrans.nnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“nnum”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableAlloyTrans.nnumColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string pk_corp
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.pk_corpColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“pk_corp”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.pk_corpColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string vproductbatchcode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.vproductbatchcodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“vproductbatchcode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.vproductbatchcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy1
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.zdy1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“zdy1”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.zdy1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy2
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.zdy2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“zdy2”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.zdy2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy3
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.zdy3Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“zdy3”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.zdy3Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy4
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.zdy4Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“zdy4”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.zdy4Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy5
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.zdy5Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“zdy5”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.zdy5Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx1
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.zyx1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“zyx1”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.zyx1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx2
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.zyx2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“zyx2”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.zyx2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx3
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.zyx3Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“zyx3”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.zyx3Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx4
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.zyx4Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“zyx4”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.zyx4Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx5
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableAlloyTrans.zyx5Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“AlloyTrans”中列“zyx5”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableAlloyTrans.zyx5Column] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class AlloyTransRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private MESIFDataSet.AlloyTransRow eventRow;

            [DebuggerNonUserCode]
            public AlloyTransRowChangeEvent(MESIFDataSet.AlloyTransRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.AlloyTransRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        public delegate void AlloyTransRowChangeEventHandler(object sender, MESIFDataSet.AlloyTransRowChangeEvent e);

        [Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
        public class BulkPurchaseDataTable : DataTable, IEnumerable
        {
            private DataColumn columncinventoryid;
            private DataColumn columncwarehouseid;
            private DataColumn columndbilldate;
            private DataColumn columninvcode;
            private DataColumn columninvname;
            private DataColumn columninvspec;
            private DataColumn columninvtype;
            private DataColumn columnnassistinnum;
            private DataColumn columnninnum;
            private DataColumn columnpk_corp;
            private DataColumn columnvbillcode;
            private DataColumn columnzdy1;
            private DataColumn columnzdy2;
            private DataColumn columnzdy3;
            private DataColumn columnzdy4;
            private DataColumn columnzdy5;
            private DataColumn columnzyx1;
            private DataColumn columnzyx2;
            private DataColumn columnzyx3;
            private DataColumn columnzyx4;
            private DataColumn columnzyx5;

            public event MESIFDataSet.BulkPurchaseRowChangeEventHandler BulkPurchaseRowChanged;

            public event MESIFDataSet.BulkPurchaseRowChangeEventHandler BulkPurchaseRowChanging;

            public event MESIFDataSet.BulkPurchaseRowChangeEventHandler BulkPurchaseRowDeleted;

            public event MESIFDataSet.BulkPurchaseRowChangeEventHandler BulkPurchaseRowDeleting;

            [DebuggerNonUserCode]
            public BulkPurchaseDataTable()
            {
                base.TableName = "BulkPurchase";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode]
            internal BulkPurchaseDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            protected BulkPurchaseDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode]
            public void AddBulkPurchaseRow(MESIFDataSet.BulkPurchaseRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.BulkPurchaseRow AddBulkPurchaseRow(string vbillcode, string cwarehouseid, string cinventoryid, string invcode, string invname, string invspec, string invtype, string dbilldate, double ninnum, int nassistinnum, string zdy1, string zdy2, string zdy3, string zdy4, string zdy5, string zyx1, string zyx2, string zyx3, string zyx4, string zyx5, string pk_corp)
            {
                MESIFDataSet.BulkPurchaseRow row = (MESIFDataSet.BulkPurchaseRow) base.NewRow();
                row.ItemArray = new object[] { 
                    vbillcode, cwarehouseid, cinventoryid, invcode, invname, invspec, invtype, dbilldate, ninnum, nassistinnum, zdy1, zdy2, zdy3, zdy4, zdy5, zyx1, 
                    zyx2, zyx3, zyx4, zyx5, pk_corp
                 };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                MESIFDataSet.BulkPurchaseDataTable table = (MESIFDataSet.BulkPurchaseDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new MESIFDataSet.BulkPurchaseDataTable();
            }

            [DebuggerNonUserCode]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(MESIFDataSet.BulkPurchaseRow);
            }

            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                MESIFDataSet set = new MESIFDataSet();
                xs.Add(set.GetSchemaSerializable());
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = 1M;
                any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                attribute.Name = "namespace";
                attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "BulkPurchaseDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                return type;
            }

            [DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnvbillcode = new DataColumn("vbillcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnvbillcode);
                this.columncwarehouseid = new DataColumn("cwarehouseid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncwarehouseid);
                this.columncinventoryid = new DataColumn("cinventoryid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncinventoryid);
                this.columninvcode = new DataColumn("invcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvcode);
                this.columninvname = new DataColumn("invname", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvname);
                this.columninvspec = new DataColumn("invspec", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvspec);
                this.columninvtype = new DataColumn("invtype", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvtype);
                this.columndbilldate = new DataColumn("dbilldate", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndbilldate);
                this.columnninnum = new DataColumn("ninnum", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnninnum);
                this.columnnassistinnum = new DataColumn("nassistinnum", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnassistinnum);
                this.columnzdy1 = new DataColumn("zdy1", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy1);
                this.columnzdy2 = new DataColumn("zdy2", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy2);
                this.columnzdy3 = new DataColumn("zdy3", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy3);
                this.columnzdy4 = new DataColumn("zdy4", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy4);
                this.columnzdy5 = new DataColumn("zdy5", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy5);
                this.columnzyx1 = new DataColumn("zyx1", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx1);
                this.columnzyx2 = new DataColumn("zyx2", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx2);
                this.columnzyx3 = new DataColumn("zyx3", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx3);
                this.columnzyx4 = new DataColumn("zyx4", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx4);
                this.columnzyx5 = new DataColumn("zyx5", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx5);
                this.columnpk_corp = new DataColumn("pk_corp", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnpk_corp);
                base.Constraints.Add(new UniqueConstraint("MaterialWarehouseKey1", new DataColumn[] { this.columnvbillcode, this.columncwarehouseid, this.columncinventoryid, this.columnpk_corp }, false));
                this.columnvbillcode.MaxLength = 0xff;
                this.columncwarehouseid.MaxLength = 0xff;
                this.columncinventoryid.MaxLength = 0xff;
                this.columninvcode.MaxLength = 0xff;
                this.columninvname.MaxLength = 0xff;
                this.columninvspec.MaxLength = 0xff;
                this.columninvtype.MaxLength = 0xff;
                this.columndbilldate.MaxLength = 0xff;
                this.columnzdy1.MaxLength = 0xff;
                this.columnzdy2.MaxLength = 0xff;
                this.columnzdy3.MaxLength = 0xff;
                this.columnzdy4.MaxLength = 0xff;
                this.columnzdy5.MaxLength = 0xff;
                this.columnzyx1.MaxLength = 0xff;
                this.columnzyx2.MaxLength = 0xff;
                this.columnzyx3.MaxLength = 0xff;
                this.columnzyx4.MaxLength = 0xff;
                this.columnzyx5.MaxLength = 0xff;
                this.columnpk_corp.MaxLength = 0xff;
            }

            [DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnvbillcode = base.Columns["vbillcode"];
                this.columncwarehouseid = base.Columns["cwarehouseid"];
                this.columncinventoryid = base.Columns["cinventoryid"];
                this.columninvcode = base.Columns["invcode"];
                this.columninvname = base.Columns["invname"];
                this.columninvspec = base.Columns["invspec"];
                this.columninvtype = base.Columns["invtype"];
                this.columndbilldate = base.Columns["dbilldate"];
                this.columnninnum = base.Columns["ninnum"];
                this.columnnassistinnum = base.Columns["nassistinnum"];
                this.columnzdy1 = base.Columns["zdy1"];
                this.columnzdy2 = base.Columns["zdy2"];
                this.columnzdy3 = base.Columns["zdy3"];
                this.columnzdy4 = base.Columns["zdy4"];
                this.columnzdy5 = base.Columns["zdy5"];
                this.columnzyx1 = base.Columns["zyx1"];
                this.columnzyx2 = base.Columns["zyx2"];
                this.columnzyx3 = base.Columns["zyx3"];
                this.columnzyx4 = base.Columns["zyx4"];
                this.columnzyx5 = base.Columns["zyx5"];
                this.columnpk_corp = base.Columns["pk_corp"];
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.BulkPurchaseRow NewBulkPurchaseRow()
            {
                return (MESIFDataSet.BulkPurchaseRow) base.NewRow();
            }

            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new MESIFDataSet.BulkPurchaseRow(builder);
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.BulkPurchaseRowChanged != null)
                {
                    this.BulkPurchaseRowChanged(this, new MESIFDataSet.BulkPurchaseRowChangeEvent((MESIFDataSet.BulkPurchaseRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.BulkPurchaseRowChanging != null)
                {
                    this.BulkPurchaseRowChanging(this, new MESIFDataSet.BulkPurchaseRowChangeEvent((MESIFDataSet.BulkPurchaseRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.BulkPurchaseRowDeleted != null)
                {
                    this.BulkPurchaseRowDeleted(this, new MESIFDataSet.BulkPurchaseRowChangeEvent((MESIFDataSet.BulkPurchaseRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.BulkPurchaseRowDeleting != null)
                {
                    this.BulkPurchaseRowDeleting(this, new MESIFDataSet.BulkPurchaseRowChangeEvent((MESIFDataSet.BulkPurchaseRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            public void RemoveBulkPurchaseRow(MESIFDataSet.BulkPurchaseRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode]
            public DataColumn cinventoryidColumn
            {
                get
                {
                    return this.columncinventoryid;
                }
            }

            [Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn cwarehouseidColumn
            {
                get
                {
                    return this.columncwarehouseid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn dbilldateColumn
            {
                get
                {
                    return this.columndbilldate;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invcodeColumn
            {
                get
                {
                    return this.columninvcode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invnameColumn
            {
                get
                {
                    return this.columninvname;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invspecColumn
            {
                get
                {
                    return this.columninvspec;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invtypeColumn
            {
                get
                {
                    return this.columninvtype;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.BulkPurchaseRow this[int index]
            {
                get
                {
                    return (MESIFDataSet.BulkPurchaseRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode]
            public DataColumn nassistinnumColumn
            {
                get
                {
                    return this.columnnassistinnum;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn ninnumColumn
            {
                get
                {
                    return this.columnninnum;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn pk_corpColumn
            {
                get
                {
                    return this.columnpk_corp;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn vbillcodeColumn
            {
                get
                {
                    return this.columnvbillcode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy1Column
            {
                get
                {
                    return this.columnzdy1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy2Column
            {
                get
                {
                    return this.columnzdy2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy3Column
            {
                get
                {
                    return this.columnzdy3;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy4Column
            {
                get
                {
                    return this.columnzdy4;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy5Column
            {
                get
                {
                    return this.columnzdy5;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx1Column
            {
                get
                {
                    return this.columnzyx1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx2Column
            {
                get
                {
                    return this.columnzyx2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx3Column
            {
                get
                {
                    return this.columnzyx3;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx4Column
            {
                get
                {
                    return this.columnzyx4;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx5Column
            {
                get
                {
                    return this.columnzyx5;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class BulkPurchaseRow : DataRow
        {
            private MESIFDataSet.BulkPurchaseDataTable tableBulkPurchase;

            [DebuggerNonUserCode]
            internal BulkPurchaseRow(DataRowBuilder rb) : base(rb)
            {
                this.tableBulkPurchase = (MESIFDataSet.BulkPurchaseDataTable) base.Table;
            }

            [DebuggerNonUserCode]
            public bool IscinventoryidNull()
            {
                return base.IsNull(this.tableBulkPurchase.cinventoryidColumn);
            }

            [DebuggerNonUserCode]
            public bool IscwarehouseidNull()
            {
                return base.IsNull(this.tableBulkPurchase.cwarehouseidColumn);
            }

            [DebuggerNonUserCode]
            public bool IsdbilldateNull()
            {
                return base.IsNull(this.tableBulkPurchase.dbilldateColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvcodeNull()
            {
                return base.IsNull(this.tableBulkPurchase.invcodeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvnameNull()
            {
                return base.IsNull(this.tableBulkPurchase.invnameColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvspecNull()
            {
                return base.IsNull(this.tableBulkPurchase.invspecColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvtypeNull()
            {
                return base.IsNull(this.tableBulkPurchase.invtypeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsnassistinnumNull()
            {
                return base.IsNull(this.tableBulkPurchase.nassistinnumColumn);
            }

            [DebuggerNonUserCode]
            public bool IsninnumNull()
            {
                return base.IsNull(this.tableBulkPurchase.ninnumColumn);
            }

            [DebuggerNonUserCode]
            public bool Ispk_corpNull()
            {
                return base.IsNull(this.tableBulkPurchase.pk_corpColumn);
            }

            [DebuggerNonUserCode]
            public bool IsvbillcodeNull()
            {
                return base.IsNull(this.tableBulkPurchase.vbillcodeColumn);
            }

            [DebuggerNonUserCode]
            public bool Iszdy1Null()
            {
                return base.IsNull(this.tableBulkPurchase.zdy1Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy2Null()
            {
                return base.IsNull(this.tableBulkPurchase.zdy2Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy3Null()
            {
                return base.IsNull(this.tableBulkPurchase.zdy3Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy4Null()
            {
                return base.IsNull(this.tableBulkPurchase.zdy4Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy5Null()
            {
                return base.IsNull(this.tableBulkPurchase.zdy5Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx1Null()
            {
                return base.IsNull(this.tableBulkPurchase.zyx1Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx2Null()
            {
                return base.IsNull(this.tableBulkPurchase.zyx2Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx3Null()
            {
                return base.IsNull(this.tableBulkPurchase.zyx3Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx4Null()
            {
                return base.IsNull(this.tableBulkPurchase.zyx4Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx5Null()
            {
                return base.IsNull(this.tableBulkPurchase.zyx5Column);
            }

            [DebuggerNonUserCode]
            public void SetcinventoryidNull()
            {
                base[this.tableBulkPurchase.cinventoryidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetcwarehouseidNull()
            {
                base[this.tableBulkPurchase.cwarehouseidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetdbilldateNull()
            {
                base[this.tableBulkPurchase.dbilldateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvcodeNull()
            {
                base[this.tableBulkPurchase.invcodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvnameNull()
            {
                base[this.tableBulkPurchase.invnameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvspecNull()
            {
                base[this.tableBulkPurchase.invspecColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvtypeNull()
            {
                base[this.tableBulkPurchase.invtypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetnassistinnumNull()
            {
                base[this.tableBulkPurchase.nassistinnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetninnumNull()
            {
                base[this.tableBulkPurchase.ninnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setpk_corpNull()
            {
                base[this.tableBulkPurchase.pk_corpColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetvbillcodeNull()
            {
                base[this.tableBulkPurchase.vbillcodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy1Null()
            {
                base[this.tableBulkPurchase.zdy1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy2Null()
            {
                base[this.tableBulkPurchase.zdy2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy3Null()
            {
                base[this.tableBulkPurchase.zdy3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy4Null()
            {
                base[this.tableBulkPurchase.zdy4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy5Null()
            {
                base[this.tableBulkPurchase.zdy5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx1Null()
            {
                base[this.tableBulkPurchase.zyx1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx2Null()
            {
                base[this.tableBulkPurchase.zyx2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx3Null()
            {
                base[this.tableBulkPurchase.zyx3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx4Null()
            {
                base[this.tableBulkPurchase.zyx4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx5Null()
            {
                base[this.tableBulkPurchase.zyx5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public string cinventoryid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.cinventoryidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“cinventoryid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.cinventoryidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string cwarehouseid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.cwarehouseidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“cwarehouseid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.cwarehouseidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string dbilldate
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.dbilldateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“dbilldate”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.dbilldateColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invcode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.invcodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“invcode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.invcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invname
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.invnameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“invname”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.invnameColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invspec
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.invspecColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“invspec”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.invspecColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invtype
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.invtypeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“invtype”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.invtypeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public int nassistinnum
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tableBulkPurchase.nassistinnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“nassistinnum”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableBulkPurchase.nassistinnumColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double ninnum
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableBulkPurchase.ninnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“ninnum”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableBulkPurchase.ninnumColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string pk_corp
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.pk_corpColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“pk_corp”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.pk_corpColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string vbillcode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.vbillcodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“vbillcode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.vbillcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy1
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.zdy1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“zdy1”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.zdy1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy2
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.zdy2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“zdy2”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.zdy2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy3
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.zdy3Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“zdy3”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.zdy3Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy4
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.zdy4Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“zdy4”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.zdy4Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy5
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.zdy5Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“zdy5”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.zdy5Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx1
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.zyx1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“zyx1”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.zyx1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx2
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.zyx2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“zyx2”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.zyx2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx3
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.zyx3Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“zyx3”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.zyx3Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx4
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.zyx4Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“zyx4”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.zyx4Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx5
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableBulkPurchase.zyx5Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“BulkPurchase”中列“zyx5”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableBulkPurchase.zyx5Column] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class BulkPurchaseRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private MESIFDataSet.BulkPurchaseRow eventRow;

            [DebuggerNonUserCode]
            public BulkPurchaseRowChangeEvent(MESIFDataSet.BulkPurchaseRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.BulkPurchaseRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        public delegate void BulkPurchaseRowChangeEventHandler(object sender, MESIFDataSet.BulkPurchaseRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class PlanOrderDataTable : DataTable, IEnumerable
        {
            private DataColumn columnddlx;
            private DataColumn columnfjhsl;
            private DataColumn columnfjlid;
            private DataColumn columngcbm;
            private DataColumn columngzzxbm;
            private DataColumn columngzzxid;
            private DataColumn columninvcode;
            private DataColumn columninvname;
            private DataColumn columninvspec;
            private DataColumn columninvtype;
            private DataColumn columnjhddh;
            private DataColumn columnjhksrq;
            private DataColumn columnjhwgsl;
            private DataColumn columnjhxxsl;
            private DataColumn columnjldwid;
            private DataColumn columnjldwmc;
            private DataColumn columnksid;
            private DataColumn columnpk_corp;
            private DataColumn columnpk_invbasdoc;
            private DataColumn columnpk_poid;
            private DataColumn columnpk_produce;
            private DataColumn columnscbmbm;
            private DataColumn columnscbmid;
            private DataColumn columnsfjj;
            private DataColumn columnxdrq;
            private DataColumn columnxqrq;
            private DataColumn columnxsddh;
            private DataColumn columnzdy1;
            private DataColumn columnzdy2;
            private DataColumn columnzdy3;
            private DataColumn columnzdy4;
            private DataColumn columnzdy5;
            private DataColumn columnztshow;
            private DataColumn columnzyx1;
            private DataColumn columnzyx2;
            private DataColumn columnzyx3;
            private DataColumn columnzyx4;
            private DataColumn columnzyx5;

            public event MESIFDataSet.PlanOrderRowChangeEventHandler PlanOrderRowChanged;

            public event MESIFDataSet.PlanOrderRowChangeEventHandler PlanOrderRowChanging;

            public event MESIFDataSet.PlanOrderRowChangeEventHandler PlanOrderRowDeleted;

            public event MESIFDataSet.PlanOrderRowChangeEventHandler PlanOrderRowDeleting;

            [DebuggerNonUserCode]
            public PlanOrderDataTable()
            {
                base.TableName = "PlanOrder";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode]
            internal PlanOrderDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            protected PlanOrderDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode]
            public void AddPlanOrderRow(MESIFDataSet.PlanOrderRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.PlanOrderRow AddPlanOrderRow(string jhddh, string xsddh, string pk_invbasdoc, string pk_produce, string invcode, string invname, string invspec, string invtype, string scbmid, string scbmbm, string gzzxid, string gzzxbm, string ztshow, string ddlx, string ksid, string sfjj, string jldwid, string jldwmc, string fjlid, double jhwgsl, double jhxxsl, int fjhsl, string jhksrq, string xdrq, string xqrq, string zdy1, string zdy2, string zdy3, string zdy4, string zdy5, string zyx1, string zyx2, string zyx3, string zyx4, string zyx5, string pk_corp, string gcbm, string pk_poid)
            {
                MESIFDataSet.PlanOrderRow row = (MESIFDataSet.PlanOrderRow) base.NewRow();
                row.ItemArray = new object[] { 
                    jhddh, xsddh, pk_invbasdoc, pk_produce, invcode, invname, invspec, invtype, scbmid, scbmbm, gzzxid, gzzxbm, ztshow, ddlx, ksid, sfjj, 
                    jldwid, jldwmc, fjlid, jhwgsl, jhxxsl, fjhsl, jhksrq, xdrq, xqrq, zdy1, zdy2, zdy3, zdy4, zdy5, zyx1, zyx2, 
                    zyx3, zyx4, zyx5, pk_corp, gcbm, pk_poid
                 };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                MESIFDataSet.PlanOrderDataTable table = (MESIFDataSet.PlanOrderDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new MESIFDataSet.PlanOrderDataTable();
            }

            [DebuggerNonUserCode]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(MESIFDataSet.PlanOrderRow);
            }

            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                MESIFDataSet set = new MESIFDataSet();
                xs.Add(set.GetSchemaSerializable());
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = 1M;
                any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                attribute.Name = "namespace";
                attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "PlanOrderDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                return type;
            }

            [DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnjhddh = new DataColumn("jhddh", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnjhddh);
                this.columnxsddh = new DataColumn("xsddh", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnxsddh);
                this.columnpk_invbasdoc = new DataColumn("pk_invbasdoc", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnpk_invbasdoc);
                this.columnpk_produce = new DataColumn("pk_produce", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnpk_produce);
                this.columninvcode = new DataColumn("invcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvcode);
                this.columninvname = new DataColumn("invname", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvname);
                this.columninvspec = new DataColumn("invspec", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvspec);
                this.columninvtype = new DataColumn("invtype", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvtype);
                this.columnscbmid = new DataColumn("scbmid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnscbmid);
                this.columnscbmbm = new DataColumn("scbmbm", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnscbmbm);
                this.columngzzxid = new DataColumn("gzzxid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columngzzxid);
                this.columngzzxbm = new DataColumn("gzzxbm", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columngzzxbm);
                this.columnztshow = new DataColumn("ztshow", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnztshow);
                this.columnddlx = new DataColumn("ddlx", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnddlx);
                this.columnksid = new DataColumn("ksid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnksid);
                this.columnsfjj = new DataColumn("sfjj", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnsfjj);
                this.columnjldwid = new DataColumn("jldwid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnjldwid);
                this.columnjldwmc = new DataColumn("jldwmc", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnjldwmc);
                this.columnfjlid = new DataColumn("fjlid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnfjlid);
                this.columnjhwgsl = new DataColumn("jhwgsl", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnjhwgsl);
                this.columnjhxxsl = new DataColumn("jhxxsl", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnjhxxsl);
                this.columnfjhsl = new DataColumn("fjhsl", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnfjhsl);
                this.columnjhksrq = new DataColumn("jhksrq", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnjhksrq);
                this.columnxdrq = new DataColumn("xdrq", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnxdrq);
                this.columnxqrq = new DataColumn("xqrq", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnxqrq);
                this.columnzdy1 = new DataColumn("zdy1", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy1);
                this.columnzdy2 = new DataColumn("zdy2", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy2);
                this.columnzdy3 = new DataColumn("zdy3", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy3);
                this.columnzdy4 = new DataColumn("zdy4", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy4);
                this.columnzdy5 = new DataColumn("zdy5", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy5);
                this.columnzyx1 = new DataColumn("zyx1", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx1);
                this.columnzyx2 = new DataColumn("zyx2", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx2);
                this.columnzyx3 = new DataColumn("zyx3", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx3);
                this.columnzyx4 = new DataColumn("zyx4", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx4);
                this.columnzyx5 = new DataColumn("zyx5", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx5);
                this.columnpk_corp = new DataColumn("pk_corp", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnpk_corp);
                this.columngcbm = new DataColumn("gcbm", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columngcbm);
                this.columnpk_poid = new DataColumn("pk_poid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnpk_poid);
                base.Constraints.Add(new UniqueConstraint("PlanOrderKey1", new DataColumn[] { this.columnjhddh, this.columnxsddh, this.columnpk_invbasdoc, this.columnpk_produce, this.columnscbmid, this.columngzzxid, this.columnksid, this.columnjldwid, this.columnjldwmc, this.columnfjlid, this.columnpk_corp, this.columngcbm, this.columnpk_poid }, false));
                this.columnjhddh.MaxLength = 0xff;
                this.columnxsddh.MaxLength = 0xff;
                this.columnpk_invbasdoc.MaxLength = 0xff;
                this.columnpk_produce.MaxLength = 0xff;
                this.columninvcode.MaxLength = 0xff;
                this.columninvname.MaxLength = 0xff;
                this.columninvspec.MaxLength = 0xff;
                this.columninvtype.MaxLength = 0xff;
                this.columnscbmid.MaxLength = 0xff;
                this.columnscbmbm.MaxLength = 0xff;
                this.columngzzxid.MaxLength = 0xff;
                this.columngzzxbm.MaxLength = 0xff;
                this.columnztshow.MaxLength = 0xff;
                this.columnddlx.MaxLength = 0xff;
                this.columnksid.MaxLength = 0xff;
                this.columnsfjj.MaxLength = 0xff;
                this.columnjldwid.MaxLength = 0xff;
                this.columnjldwmc.MaxLength = 0xff;
                this.columnfjlid.MaxLength = 0xff;
                this.columnjhksrq.MaxLength = 0xff;
                this.columnxdrq.MaxLength = 0xff;
                this.columnxqrq.MaxLength = 0xff;
                this.columnzdy1.MaxLength = 0xff;
                this.columnzdy2.MaxLength = 0xff;
                this.columnzdy3.MaxLength = 0xff;
                this.columnzdy4.MaxLength = 0xff;
                this.columnzdy5.MaxLength = 0xff;
                this.columnzyx1.MaxLength = 0xff;
                this.columnzyx2.MaxLength = 0xff;
                this.columnzyx3.MaxLength = 0xff;
                this.columnzyx4.MaxLength = 0xff;
                this.columnzyx5.MaxLength = 0xff;
                this.columnpk_corp.MaxLength = 0xff;
                this.columngcbm.MaxLength = 0xff;
                this.columnpk_poid.MaxLength = 0xff;
            }

            [DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnjhddh = base.Columns["jhddh"];
                this.columnxsddh = base.Columns["xsddh"];
                this.columnpk_invbasdoc = base.Columns["pk_invbasdoc"];
                this.columnpk_produce = base.Columns["pk_produce"];
                this.columninvcode = base.Columns["invcode"];
                this.columninvname = base.Columns["invname"];
                this.columninvspec = base.Columns["invspec"];
                this.columninvtype = base.Columns["invtype"];
                this.columnscbmid = base.Columns["scbmid"];
                this.columnscbmbm = base.Columns["scbmbm"];
                this.columngzzxid = base.Columns["gzzxid"];
                this.columngzzxbm = base.Columns["gzzxbm"];
                this.columnztshow = base.Columns["ztshow"];
                this.columnddlx = base.Columns["ddlx"];
                this.columnksid = base.Columns["ksid"];
                this.columnsfjj = base.Columns["sfjj"];
                this.columnjldwid = base.Columns["jldwid"];
                this.columnjldwmc = base.Columns["jldwmc"];
                this.columnfjlid = base.Columns["fjlid"];
                this.columnjhwgsl = base.Columns["jhwgsl"];
                this.columnjhxxsl = base.Columns["jhxxsl"];
                this.columnfjhsl = base.Columns["fjhsl"];
                this.columnjhksrq = base.Columns["jhksrq"];
                this.columnxdrq = base.Columns["xdrq"];
                this.columnxqrq = base.Columns["xqrq"];
                this.columnzdy1 = base.Columns["zdy1"];
                this.columnzdy2 = base.Columns["zdy2"];
                this.columnzdy3 = base.Columns["zdy3"];
                this.columnzdy4 = base.Columns["zdy4"];
                this.columnzdy5 = base.Columns["zdy5"];
                this.columnzyx1 = base.Columns["zyx1"];
                this.columnzyx2 = base.Columns["zyx2"];
                this.columnzyx3 = base.Columns["zyx3"];
                this.columnzyx4 = base.Columns["zyx4"];
                this.columnzyx5 = base.Columns["zyx5"];
                this.columnpk_corp = base.Columns["pk_corp"];
                this.columngcbm = base.Columns["gcbm"];
                this.columnpk_poid = base.Columns["pk_poid"];
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.PlanOrderRow NewPlanOrderRow()
            {
                return (MESIFDataSet.PlanOrderRow) base.NewRow();
            }

            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new MESIFDataSet.PlanOrderRow(builder);
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.PlanOrderRowChanged != null)
                {
                    this.PlanOrderRowChanged(this, new MESIFDataSet.PlanOrderRowChangeEvent((MESIFDataSet.PlanOrderRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.PlanOrderRowChanging != null)
                {
                    this.PlanOrderRowChanging(this, new MESIFDataSet.PlanOrderRowChangeEvent((MESIFDataSet.PlanOrderRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.PlanOrderRowDeleted != null)
                {
                    this.PlanOrderRowDeleted(this, new MESIFDataSet.PlanOrderRowChangeEvent((MESIFDataSet.PlanOrderRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.PlanOrderRowDeleting != null)
                {
                    this.PlanOrderRowDeleting(this, new MESIFDataSet.PlanOrderRowChangeEvent((MESIFDataSet.PlanOrderRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            public void RemovePlanOrderRow(MESIFDataSet.PlanOrderRow row)
            {
                base.Rows.Remove(row);
            }

            [Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn ddlxColumn
            {
                get
                {
                    return this.columnddlx;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn fjhslColumn
            {
                get
                {
                    return this.columnfjhsl;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn fjlidColumn
            {
                get
                {
                    return this.columnfjlid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn gcbmColumn
            {
                get
                {
                    return this.columngcbm;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn gzzxbmColumn
            {
                get
                {
                    return this.columngzzxbm;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn gzzxidColumn
            {
                get
                {
                    return this.columngzzxid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invcodeColumn
            {
                get
                {
                    return this.columninvcode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invnameColumn
            {
                get
                {
                    return this.columninvname;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invspecColumn
            {
                get
                {
                    return this.columninvspec;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invtypeColumn
            {
                get
                {
                    return this.columninvtype;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.PlanOrderRow this[int index]
            {
                get
                {
                    return (MESIFDataSet.PlanOrderRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode]
            public DataColumn jhddhColumn
            {
                get
                {
                    return this.columnjhddh;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn jhksrqColumn
            {
                get
                {
                    return this.columnjhksrq;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn jhwgslColumn
            {
                get
                {
                    return this.columnjhwgsl;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn jhxxslColumn
            {
                get
                {
                    return this.columnjhxxsl;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn jldwidColumn
            {
                get
                {
                    return this.columnjldwid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn jldwmcColumn
            {
                get
                {
                    return this.columnjldwmc;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn ksidColumn
            {
                get
                {
                    return this.columnksid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn pk_corpColumn
            {
                get
                {
                    return this.columnpk_corp;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn pk_invbasdocColumn
            {
                get
                {
                    return this.columnpk_invbasdoc;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn pk_poidColumn
            {
                get
                {
                    return this.columnpk_poid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn pk_produceColumn
            {
                get
                {
                    return this.columnpk_produce;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn scbmbmColumn
            {
                get
                {
                    return this.columnscbmbm;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn scbmidColumn
            {
                get
                {
                    return this.columnscbmid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn sfjjColumn
            {
                get
                {
                    return this.columnsfjj;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn xdrqColumn
            {
                get
                {
                    return this.columnxdrq;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn xqrqColumn
            {
                get
                {
                    return this.columnxqrq;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn xsddhColumn
            {
                get
                {
                    return this.columnxsddh;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy1Column
            {
                get
                {
                    return this.columnzdy1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy2Column
            {
                get
                {
                    return this.columnzdy2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy3Column
            {
                get
                {
                    return this.columnzdy3;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy4Column
            {
                get
                {
                    return this.columnzdy4;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy5Column
            {
                get
                {
                    return this.columnzdy5;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn ztshowColumn
            {
                get
                {
                    return this.columnztshow;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx1Column
            {
                get
                {
                    return this.columnzyx1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx2Column
            {
                get
                {
                    return this.columnzyx2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx3Column
            {
                get
                {
                    return this.columnzyx3;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx4Column
            {
                get
                {
                    return this.columnzyx4;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx5Column
            {
                get
                {
                    return this.columnzyx5;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class PlanOrderRow : DataRow
        {
            private MESIFDataSet.PlanOrderDataTable tablePlanOrder;

            [DebuggerNonUserCode]
            internal PlanOrderRow(DataRowBuilder rb) : base(rb)
            {
                this.tablePlanOrder = (MESIFDataSet.PlanOrderDataTable) base.Table;
            }

            [DebuggerNonUserCode]
            public bool IsddlxNull()
            {
                return base.IsNull(this.tablePlanOrder.ddlxColumn);
            }

            [DebuggerNonUserCode]
            public bool IsfjhslNull()
            {
                return base.IsNull(this.tablePlanOrder.fjhslColumn);
            }

            [DebuggerNonUserCode]
            public bool IsfjlidNull()
            {
                return base.IsNull(this.tablePlanOrder.fjlidColumn);
            }

            [DebuggerNonUserCode]
            public bool IsgcbmNull()
            {
                return base.IsNull(this.tablePlanOrder.gcbmColumn);
            }

            [DebuggerNonUserCode]
            public bool IsgzzxbmNull()
            {
                return base.IsNull(this.tablePlanOrder.gzzxbmColumn);
            }

            [DebuggerNonUserCode]
            public bool IsgzzxidNull()
            {
                return base.IsNull(this.tablePlanOrder.gzzxidColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvcodeNull()
            {
                return base.IsNull(this.tablePlanOrder.invcodeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvnameNull()
            {
                return base.IsNull(this.tablePlanOrder.invnameColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvspecNull()
            {
                return base.IsNull(this.tablePlanOrder.invspecColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvtypeNull()
            {
                return base.IsNull(this.tablePlanOrder.invtypeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsjhddhNull()
            {
                return base.IsNull(this.tablePlanOrder.jhddhColumn);
            }

            [DebuggerNonUserCode]
            public bool IsjhksrqNull()
            {
                return base.IsNull(this.tablePlanOrder.jhksrqColumn);
            }

            [DebuggerNonUserCode]
            public bool IsjhwgslNull()
            {
                return base.IsNull(this.tablePlanOrder.jhwgslColumn);
            }

            [DebuggerNonUserCode]
            public bool IsjhxxslNull()
            {
                return base.IsNull(this.tablePlanOrder.jhxxslColumn);
            }

            [DebuggerNonUserCode]
            public bool IsjldwidNull()
            {
                return base.IsNull(this.tablePlanOrder.jldwidColumn);
            }

            [DebuggerNonUserCode]
            public bool IsjldwmcNull()
            {
                return base.IsNull(this.tablePlanOrder.jldwmcColumn);
            }

            [DebuggerNonUserCode]
            public bool IsksidNull()
            {
                return base.IsNull(this.tablePlanOrder.ksidColumn);
            }

            [DebuggerNonUserCode]
            public bool Ispk_corpNull()
            {
                return base.IsNull(this.tablePlanOrder.pk_corpColumn);
            }

            [DebuggerNonUserCode]
            public bool Ispk_invbasdocNull()
            {
                return base.IsNull(this.tablePlanOrder.pk_invbasdocColumn);
            }

            [DebuggerNonUserCode]
            public bool Ispk_poidNull()
            {
                return base.IsNull(this.tablePlanOrder.pk_poidColumn);
            }

            [DebuggerNonUserCode]
            public bool Ispk_produceNull()
            {
                return base.IsNull(this.tablePlanOrder.pk_produceColumn);
            }

            [DebuggerNonUserCode]
            public bool IsscbmbmNull()
            {
                return base.IsNull(this.tablePlanOrder.scbmbmColumn);
            }

            [DebuggerNonUserCode]
            public bool IsscbmidNull()
            {
                return base.IsNull(this.tablePlanOrder.scbmidColumn);
            }

            [DebuggerNonUserCode]
            public bool IssfjjNull()
            {
                return base.IsNull(this.tablePlanOrder.sfjjColumn);
            }

            [DebuggerNonUserCode]
            public bool IsxdrqNull()
            {
                return base.IsNull(this.tablePlanOrder.xdrqColumn);
            }

            [DebuggerNonUserCode]
            public bool IsxqrqNull()
            {
                return base.IsNull(this.tablePlanOrder.xqrqColumn);
            }

            [DebuggerNonUserCode]
            public bool IsxsddhNull()
            {
                return base.IsNull(this.tablePlanOrder.xsddhColumn);
            }

            [DebuggerNonUserCode]
            public bool Iszdy1Null()
            {
                return base.IsNull(this.tablePlanOrder.zdy1Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy2Null()
            {
                return base.IsNull(this.tablePlanOrder.zdy2Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy3Null()
            {
                return base.IsNull(this.tablePlanOrder.zdy3Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy4Null()
            {
                return base.IsNull(this.tablePlanOrder.zdy4Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy5Null()
            {
                return base.IsNull(this.tablePlanOrder.zdy5Column);
            }

            [DebuggerNonUserCode]
            public bool IsztshowNull()
            {
                return base.IsNull(this.tablePlanOrder.ztshowColumn);
            }

            [DebuggerNonUserCode]
            public bool Iszyx1Null()
            {
                return base.IsNull(this.tablePlanOrder.zyx1Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx2Null()
            {
                return base.IsNull(this.tablePlanOrder.zyx2Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx3Null()
            {
                return base.IsNull(this.tablePlanOrder.zyx3Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx4Null()
            {
                return base.IsNull(this.tablePlanOrder.zyx4Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx5Null()
            {
                return base.IsNull(this.tablePlanOrder.zyx5Column);
            }

            [DebuggerNonUserCode]
            public void SetddlxNull()
            {
                base[this.tablePlanOrder.ddlxColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetfjhslNull()
            {
                base[this.tablePlanOrder.fjhslColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetfjlidNull()
            {
                base[this.tablePlanOrder.fjlidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetgcbmNull()
            {
                base[this.tablePlanOrder.gcbmColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetgzzxbmNull()
            {
                base[this.tablePlanOrder.gzzxbmColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetgzzxidNull()
            {
                base[this.tablePlanOrder.gzzxidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvcodeNull()
            {
                base[this.tablePlanOrder.invcodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvnameNull()
            {
                base[this.tablePlanOrder.invnameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvspecNull()
            {
                base[this.tablePlanOrder.invspecColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvtypeNull()
            {
                base[this.tablePlanOrder.invtypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetjhddhNull()
            {
                base[this.tablePlanOrder.jhddhColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetjhksrqNull()
            {
                base[this.tablePlanOrder.jhksrqColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetjhwgslNull()
            {
                base[this.tablePlanOrder.jhwgslColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetjhxxslNull()
            {
                base[this.tablePlanOrder.jhxxslColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetjldwidNull()
            {
                base[this.tablePlanOrder.jldwidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetjldwmcNull()
            {
                base[this.tablePlanOrder.jldwmcColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetksidNull()
            {
                base[this.tablePlanOrder.ksidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setpk_corpNull()
            {
                base[this.tablePlanOrder.pk_corpColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setpk_invbasdocNull()
            {
                base[this.tablePlanOrder.pk_invbasdocColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setpk_poidNull()
            {
                base[this.tablePlanOrder.pk_poidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setpk_produceNull()
            {
                base[this.tablePlanOrder.pk_produceColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetscbmbmNull()
            {
                base[this.tablePlanOrder.scbmbmColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetscbmidNull()
            {
                base[this.tablePlanOrder.scbmidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetsfjjNull()
            {
                base[this.tablePlanOrder.sfjjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetxdrqNull()
            {
                base[this.tablePlanOrder.xdrqColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetxqrqNull()
            {
                base[this.tablePlanOrder.xqrqColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetxsddhNull()
            {
                base[this.tablePlanOrder.xsddhColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy1Null()
            {
                base[this.tablePlanOrder.zdy1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy2Null()
            {
                base[this.tablePlanOrder.zdy2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy3Null()
            {
                base[this.tablePlanOrder.zdy3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy4Null()
            {
                base[this.tablePlanOrder.zdy4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy5Null()
            {
                base[this.tablePlanOrder.zdy5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetztshowNull()
            {
                base[this.tablePlanOrder.ztshowColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx1Null()
            {
                base[this.tablePlanOrder.zyx1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx2Null()
            {
                base[this.tablePlanOrder.zyx2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx3Null()
            {
                base[this.tablePlanOrder.zyx3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx4Null()
            {
                base[this.tablePlanOrder.zyx4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx5Null()
            {
                base[this.tablePlanOrder.zyx5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public string ddlx
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.ddlxColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“ddlx”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.ddlxColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public int fjhsl
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tablePlanOrder.fjhslColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“fjhsl”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tablePlanOrder.fjhslColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string fjlid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.fjlidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“fjlid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.fjlidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string gcbm
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.gcbmColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“gcbm”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.gcbmColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string gzzxbm
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.gzzxbmColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“gzzxbm”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.gzzxbmColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string gzzxid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.gzzxidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“gzzxid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.gzzxidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invcode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.invcodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“invcode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.invcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invname
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.invnameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“invname”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.invnameColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invspec
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.invspecColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“invspec”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.invspecColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invtype
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.invtypeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“invtype”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.invtypeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string jhddh
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.jhddhColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“jhddh”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.jhddhColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string jhksrq
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.jhksrqColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“jhksrq”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.jhksrqColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double jhwgsl
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tablePlanOrder.jhwgslColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“jhwgsl”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tablePlanOrder.jhwgslColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double jhxxsl
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tablePlanOrder.jhxxslColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“jhxxsl”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tablePlanOrder.jhxxslColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string jldwid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.jldwidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“jldwid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.jldwidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string jldwmc
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.jldwmcColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“jldwmc”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.jldwmcColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string ksid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.ksidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“ksid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.ksidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string pk_corp
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.pk_corpColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“pk_corp”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.pk_corpColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string pk_invbasdoc
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.pk_invbasdocColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“pk_invbasdoc”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.pk_invbasdocColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string pk_poid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.pk_poidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“pk_poid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.pk_poidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string pk_produce
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.pk_produceColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“pk_produce”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.pk_produceColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string scbmbm
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.scbmbmColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“scbmbm”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.scbmbmColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string scbmid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.scbmidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“scbmid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.scbmidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string sfjj
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.sfjjColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“sfjj”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.sfjjColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string xdrq
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.xdrqColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“xdrq”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.xdrqColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string xqrq
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.xqrqColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“xqrq”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.xqrqColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string xsddh
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.xsddhColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“xsddh”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.xsddhColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy1
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.zdy1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“zdy1”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.zdy1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy2
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.zdy2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“zdy2”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.zdy2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy3
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.zdy3Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“zdy3”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.zdy3Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy4
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.zdy4Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“zdy4”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.zdy4Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy5
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.zdy5Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“zdy5”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.zdy5Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string ztshow
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.ztshowColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“ztshow”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.ztshowColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx1
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.zyx1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“zyx1”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.zyx1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx2
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.zyx2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“zyx2”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.zyx2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx3
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.zyx3Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“zyx3”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.zyx3Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx4
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.zyx4Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“zyx4”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.zyx4Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx5
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tablePlanOrder.zyx5Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“PlanOrder”中列“zyx5”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tablePlanOrder.zyx5Column] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class PlanOrderRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private MESIFDataSet.PlanOrderRow eventRow;

            [DebuggerNonUserCode]
            public PlanOrderRowChangeEvent(MESIFDataSet.PlanOrderRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.PlanOrderRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        public delegate void PlanOrderRowChangeEventHandler(object sender, MESIFDataSet.PlanOrderRowChangeEvent e);

        [Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
        public class SteelMaterialWarehouseDataTable : DataTable, IEnumerable
        {
            private DataColumn columncinventoryid;
            private DataColumn columncwarehouseid;
            private DataColumn columndbilldate;
            private DataColumn columninvcode;
            private DataColumn columninvname;
            private DataColumn columninvspec;
            private DataColumn columninvtype;
            private DataColumn columnnassistinnum;
            private DataColumn columnninnum;
            private DataColumn columnpk_corp;
            private DataColumn columnvbillcode;
            private DataColumn columnzdy1;
            private DataColumn columnzdy2;
            private DataColumn columnzdy3;
            private DataColumn columnzdy4;
            private DataColumn columnzdy5;
            private DataColumn columnzyx1;
            private DataColumn columnzyx2;
            private DataColumn columnzyx3;
            private DataColumn columnzyx4;
            private DataColumn columnzyx5;

            public event MESIFDataSet.SteelMaterialWarehouseRowChangeEventHandler SteelMaterialWarehouseRowChanged;

            public event MESIFDataSet.SteelMaterialWarehouseRowChangeEventHandler SteelMaterialWarehouseRowChanging;

            public event MESIFDataSet.SteelMaterialWarehouseRowChangeEventHandler SteelMaterialWarehouseRowDeleted;

            public event MESIFDataSet.SteelMaterialWarehouseRowChangeEventHandler SteelMaterialWarehouseRowDeleting;

            [DebuggerNonUserCode]
            public SteelMaterialWarehouseDataTable()
            {
                base.TableName = "SteelMaterialWarehouse";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode]
            internal SteelMaterialWarehouseDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            protected SteelMaterialWarehouseDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode]
            public void AddSteelMaterialWarehouseRow(MESIFDataSet.SteelMaterialWarehouseRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.SteelMaterialWarehouseRow AddSteelMaterialWarehouseRow(string vbillcode, string cwarehouseid, string dbilldate, string cinventoryid, string invcode, string invname, string invspec, string invtype, double ninnum, int nassistinnum, string zdy1, string zdy2, string zdy3, string zdy4, string zdy5, string zyx1, string zyx2, string zyx3, string zyx4, string zyx5, string pk_corp)
            {
                MESIFDataSet.SteelMaterialWarehouseRow row = (MESIFDataSet.SteelMaterialWarehouseRow) base.NewRow();
                row.ItemArray = new object[] { 
                    vbillcode, cwarehouseid, dbilldate, cinventoryid, invcode, invname, invspec, invtype, ninnum, nassistinnum, zdy1, zdy2, zdy3, zdy4, zdy5, zyx1, 
                    zyx2, zyx3, zyx4, zyx5, pk_corp
                 };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                MESIFDataSet.SteelMaterialWarehouseDataTable table = (MESIFDataSet.SteelMaterialWarehouseDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new MESIFDataSet.SteelMaterialWarehouseDataTable();
            }

            [DebuggerNonUserCode]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(MESIFDataSet.SteelMaterialWarehouseRow);
            }

            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                MESIFDataSet set = new MESIFDataSet();
                xs.Add(set.GetSchemaSerializable());
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = 1M;
                any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                attribute.Name = "namespace";
                attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "SteelMaterialWarehouseDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                return type;
            }

            [DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnvbillcode = new DataColumn("vbillcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnvbillcode);
                this.columncwarehouseid = new DataColumn("cwarehouseid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncwarehouseid);
                this.columndbilldate = new DataColumn("dbilldate", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndbilldate);
                this.columncinventoryid = new DataColumn("cinventoryid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncinventoryid);
                this.columninvcode = new DataColumn("invcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvcode);
                this.columninvname = new DataColumn("invname", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvname);
                this.columninvspec = new DataColumn("invspec", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvspec);
                this.columninvtype = new DataColumn("invtype", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvtype);
                this.columnninnum = new DataColumn("ninnum", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnninnum);
                this.columnnassistinnum = new DataColumn("nassistinnum", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnassistinnum);
                this.columnzdy1 = new DataColumn("zdy1", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy1);
                this.columnzdy2 = new DataColumn("zdy2", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy2);
                this.columnzdy3 = new DataColumn("zdy3", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy3);
                this.columnzdy4 = new DataColumn("zdy4", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy4);
                this.columnzdy5 = new DataColumn("zdy5", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy5);
                this.columnzyx1 = new DataColumn("zyx1", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx1);
                this.columnzyx2 = new DataColumn("zyx2", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx2);
                this.columnzyx3 = new DataColumn("zyx3", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx3);
                this.columnzyx4 = new DataColumn("zyx4", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx4);
                this.columnzyx5 = new DataColumn("zyx5", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzyx5);
                this.columnpk_corp = new DataColumn("pk_corp", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnpk_corp);
                base.Constraints.Add(new UniqueConstraint("SteelMaterialWarehouseKey1", new DataColumn[] { this.columnvbillcode, this.columncwarehouseid, this.columncinventoryid, this.columnpk_corp }, false));
                this.columnvbillcode.MaxLength = 0xff;
                this.columncwarehouseid.MaxLength = 0xff;
                this.columndbilldate.MaxLength = 0xff;
                this.columncinventoryid.MaxLength = 0xff;
                this.columninvcode.MaxLength = 0xff;
                this.columninvname.MaxLength = 0xff;
                this.columninvspec.MaxLength = 0xff;
                this.columninvtype.MaxLength = 0xff;
                this.columnzdy1.MaxLength = 0xff;
                this.columnzdy2.MaxLength = 0xff;
                this.columnzdy3.MaxLength = 0xff;
                this.columnzdy4.MaxLength = 0xff;
                this.columnzdy5.MaxLength = 0xff;
                this.columnzyx1.MaxLength = 0xff;
                this.columnzyx2.MaxLength = 0xff;
                this.columnzyx3.MaxLength = 0xff;
                this.columnzyx4.MaxLength = 0xff;
                this.columnzyx5.MaxLength = 0xff;
                this.columnpk_corp.MaxLength = 0xff;
            }

            [DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnvbillcode = base.Columns["vbillcode"];
                this.columncwarehouseid = base.Columns["cwarehouseid"];
                this.columndbilldate = base.Columns["dbilldate"];
                this.columncinventoryid = base.Columns["cinventoryid"];
                this.columninvcode = base.Columns["invcode"];
                this.columninvname = base.Columns["invname"];
                this.columninvspec = base.Columns["invspec"];
                this.columninvtype = base.Columns["invtype"];
                this.columnninnum = base.Columns["ninnum"];
                this.columnnassistinnum = base.Columns["nassistinnum"];
                this.columnzdy1 = base.Columns["zdy1"];
                this.columnzdy2 = base.Columns["zdy2"];
                this.columnzdy3 = base.Columns["zdy3"];
                this.columnzdy4 = base.Columns["zdy4"];
                this.columnzdy5 = base.Columns["zdy5"];
                this.columnzyx1 = base.Columns["zyx1"];
                this.columnzyx2 = base.Columns["zyx2"];
                this.columnzyx3 = base.Columns["zyx3"];
                this.columnzyx4 = base.Columns["zyx4"];
                this.columnzyx5 = base.Columns["zyx5"];
                this.columnpk_corp = base.Columns["pk_corp"];
            }

            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new MESIFDataSet.SteelMaterialWarehouseRow(builder);
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.SteelMaterialWarehouseRow NewSteelMaterialWarehouseRow()
            {
                return (MESIFDataSet.SteelMaterialWarehouseRow) base.NewRow();
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.SteelMaterialWarehouseRowChanged != null)
                {
                    this.SteelMaterialWarehouseRowChanged(this, new MESIFDataSet.SteelMaterialWarehouseRowChangeEvent((MESIFDataSet.SteelMaterialWarehouseRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.SteelMaterialWarehouseRowChanging != null)
                {
                    this.SteelMaterialWarehouseRowChanging(this, new MESIFDataSet.SteelMaterialWarehouseRowChangeEvent((MESIFDataSet.SteelMaterialWarehouseRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.SteelMaterialWarehouseRowDeleted != null)
                {
                    this.SteelMaterialWarehouseRowDeleted(this, new MESIFDataSet.SteelMaterialWarehouseRowChangeEvent((MESIFDataSet.SteelMaterialWarehouseRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.SteelMaterialWarehouseRowDeleting != null)
                {
                    this.SteelMaterialWarehouseRowDeleting(this, new MESIFDataSet.SteelMaterialWarehouseRowChangeEvent((MESIFDataSet.SteelMaterialWarehouseRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            public void RemoveSteelMaterialWarehouseRow(MESIFDataSet.SteelMaterialWarehouseRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode]
            public DataColumn cinventoryidColumn
            {
                get
                {
                    return this.columncinventoryid;
                }
            }

            [DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn cwarehouseidColumn
            {
                get
                {
                    return this.columncwarehouseid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn dbilldateColumn
            {
                get
                {
                    return this.columndbilldate;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invcodeColumn
            {
                get
                {
                    return this.columninvcode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invnameColumn
            {
                get
                {
                    return this.columninvname;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invspecColumn
            {
                get
                {
                    return this.columninvspec;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invtypeColumn
            {
                get
                {
                    return this.columninvtype;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.SteelMaterialWarehouseRow this[int index]
            {
                get
                {
                    return (MESIFDataSet.SteelMaterialWarehouseRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode]
            public DataColumn nassistinnumColumn
            {
                get
                {
                    return this.columnnassistinnum;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn ninnumColumn
            {
                get
                {
                    return this.columnninnum;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn pk_corpColumn
            {
                get
                {
                    return this.columnpk_corp;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn vbillcodeColumn
            {
                get
                {
                    return this.columnvbillcode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy1Column
            {
                get
                {
                    return this.columnzdy1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy2Column
            {
                get
                {
                    return this.columnzdy2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy3Column
            {
                get
                {
                    return this.columnzdy3;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy4Column
            {
                get
                {
                    return this.columnzdy4;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy5Column
            {
                get
                {
                    return this.columnzdy5;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx1Column
            {
                get
                {
                    return this.columnzyx1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx2Column
            {
                get
                {
                    return this.columnzyx2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx3Column
            {
                get
                {
                    return this.columnzyx3;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx4Column
            {
                get
                {
                    return this.columnzyx4;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zyx5Column
            {
                get
                {
                    return this.columnzyx5;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class SteelMaterialWarehouseRow : DataRow
        {
            private MESIFDataSet.SteelMaterialWarehouseDataTable tableSteelMaterialWarehouse;

            [DebuggerNonUserCode]
            internal SteelMaterialWarehouseRow(DataRowBuilder rb) : base(rb)
            {
                this.tableSteelMaterialWarehouse = (MESIFDataSet.SteelMaterialWarehouseDataTable) base.Table;
            }

            [DebuggerNonUserCode]
            public bool IscinventoryidNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.cinventoryidColumn);
            }

            [DebuggerNonUserCode]
            public bool IscwarehouseidNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.cwarehouseidColumn);
            }

            [DebuggerNonUserCode]
            public bool IsdbilldateNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.dbilldateColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvcodeNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.invcodeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvnameNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.invnameColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvspecNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.invspecColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvtypeNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.invtypeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsnassistinnumNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.nassistinnumColumn);
            }

            [DebuggerNonUserCode]
            public bool IsninnumNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.ninnumColumn);
            }

            [DebuggerNonUserCode]
            public bool Ispk_corpNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.pk_corpColumn);
            }

            [DebuggerNonUserCode]
            public bool IsvbillcodeNull()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.vbillcodeColumn);
            }

            [DebuggerNonUserCode]
            public bool Iszdy1Null()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.zdy1Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy2Null()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.zdy2Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy3Null()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.zdy3Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy4Null()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.zdy4Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy5Null()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.zdy5Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx1Null()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.zyx1Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx2Null()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.zyx2Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx3Null()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.zyx3Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx4Null()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.zyx4Column);
            }

            [DebuggerNonUserCode]
            public bool Iszyx5Null()
            {
                return base.IsNull(this.tableSteelMaterialWarehouse.zyx5Column);
            }

            [DebuggerNonUserCode]
            public void SetcinventoryidNull()
            {
                base[this.tableSteelMaterialWarehouse.cinventoryidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetcwarehouseidNull()
            {
                base[this.tableSteelMaterialWarehouse.cwarehouseidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetdbilldateNull()
            {
                base[this.tableSteelMaterialWarehouse.dbilldateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvcodeNull()
            {
                base[this.tableSteelMaterialWarehouse.invcodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvnameNull()
            {
                base[this.tableSteelMaterialWarehouse.invnameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvspecNull()
            {
                base[this.tableSteelMaterialWarehouse.invspecColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvtypeNull()
            {
                base[this.tableSteelMaterialWarehouse.invtypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetnassistinnumNull()
            {
                base[this.tableSteelMaterialWarehouse.nassistinnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetninnumNull()
            {
                base[this.tableSteelMaterialWarehouse.ninnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setpk_corpNull()
            {
                base[this.tableSteelMaterialWarehouse.pk_corpColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetvbillcodeNull()
            {
                base[this.tableSteelMaterialWarehouse.vbillcodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy1Null()
            {
                base[this.tableSteelMaterialWarehouse.zdy1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy2Null()
            {
                base[this.tableSteelMaterialWarehouse.zdy2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy3Null()
            {
                base[this.tableSteelMaterialWarehouse.zdy3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy4Null()
            {
                base[this.tableSteelMaterialWarehouse.zdy4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy5Null()
            {
                base[this.tableSteelMaterialWarehouse.zdy5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx1Null()
            {
                base[this.tableSteelMaterialWarehouse.zyx1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx2Null()
            {
                base[this.tableSteelMaterialWarehouse.zyx2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx3Null()
            {
                base[this.tableSteelMaterialWarehouse.zyx3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx4Null()
            {
                base[this.tableSteelMaterialWarehouse.zyx4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzyx5Null()
            {
                base[this.tableSteelMaterialWarehouse.zyx5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public string cinventoryid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.cinventoryidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“cinventoryid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.cinventoryidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string cwarehouseid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.cwarehouseidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“cwarehouseid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.cwarehouseidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string dbilldate
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.dbilldateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“dbilldate”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.dbilldateColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invcode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.invcodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“invcode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.invcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invname
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.invnameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“invname”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.invnameColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invspec
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.invspecColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“invspec”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.invspecColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invtype
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.invtypeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“invtype”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.invtypeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public int nassistinnum
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tableSteelMaterialWarehouse.nassistinnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“nassistinnum”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.nassistinnumColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double ninnum
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableSteelMaterialWarehouse.ninnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“ninnum”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.ninnumColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string pk_corp
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.pk_corpColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“pk_corp”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.pk_corpColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string vbillcode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.vbillcodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“vbillcode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.vbillcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy1
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.zdy1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“zdy1”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.zdy1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy2
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.zdy2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“zdy2”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.zdy2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy3
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.zdy3Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“zdy3”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.zdy3Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy4
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.zdy4Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“zdy4”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.zdy4Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy5
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.zdy5Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“zdy5”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.zdy5Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx1
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.zyx1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“zyx1”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.zyx1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx2
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.zyx2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“zyx2”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.zyx2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx3
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.zyx3Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“zyx3”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.zyx3Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx4
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.zyx4Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“zyx4”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.zyx4Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zyx5
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelMaterialWarehouse.zyx5Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelMaterialWarehouse”中列“zyx5”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelMaterialWarehouse.zyx5Column] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class SteelMaterialWarehouseRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private MESIFDataSet.SteelMaterialWarehouseRow eventRow;

            [DebuggerNonUserCode]
            public SteelMaterialWarehouseRowChangeEvent(MESIFDataSet.SteelMaterialWarehouseRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.SteelMaterialWarehouseRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        public delegate void SteelMaterialWarehouseRowChangeEventHandler(object sender, MESIFDataSet.SteelMaterialWarehouseRowChangeEvent e);

        [Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
        public class SteelTreasuryDataTable : DataTable, IEnumerable
        {
            private DataColumn columncinventoryid;
            private DataColumn columncinwarehouseid;
            private DataColumn columncoutwarehouseid;
            private DataColumn columndbilldate;
            private DataColumn columninvcode;
            private DataColumn columninvname;
            private DataColumn columninvspec;
            private DataColumn columninvtype;
            private DataColumn columnnassistnum;
            private DataColumn columnnnum;
            private DataColumn columnpk_corp;
            private DataColumn columnzdy1;
            private DataColumn columnzdy2;
            private DataColumn columnzdy3;
            private DataColumn columnzdy4;
            private DataColumn columnzdy5;
            private DataColumn columnzxy1;
            private DataColumn columnzxy2;
            private DataColumn columnzxy3;
            private DataColumn columnzxy4;
            private DataColumn columnzxy5;

            public event MESIFDataSet.SteelTreasuryRowChangeEventHandler SteelTreasuryRowChanged;

            public event MESIFDataSet.SteelTreasuryRowChangeEventHandler SteelTreasuryRowChanging;

            public event MESIFDataSet.SteelTreasuryRowChangeEventHandler SteelTreasuryRowDeleted;

            public event MESIFDataSet.SteelTreasuryRowChangeEventHandler SteelTreasuryRowDeleting;

            [DebuggerNonUserCode]
            public SteelTreasuryDataTable()
            {
                base.TableName = "SteelTreasury";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode]
            internal SteelTreasuryDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            protected SteelTreasuryDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode]
            public void AddSteelTreasuryRow(MESIFDataSet.SteelTreasuryRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.SteelTreasuryRow AddSteelTreasuryRow(string cinventoryid, string invcode, string invname, string invspec, string invtype, string dbilldate, string coutwarehouseid, string cinwarehouseid, double nnum, int nassistnum, string zdy1, string zdy2, string zdy3, string zdy4, string zdy5, string zxy1, string zxy2, string zxy3, string zxy4, string zxy5, string pk_corp)
            {
                MESIFDataSet.SteelTreasuryRow row = (MESIFDataSet.SteelTreasuryRow) base.NewRow();
                row.ItemArray = new object[] { 
                    cinventoryid, invcode, invname, invspec, invtype, dbilldate, coutwarehouseid, cinwarehouseid, nnum, nassistnum, zdy1, zdy2, zdy3, zdy4, zdy5, zxy1, 
                    zxy2, zxy3, zxy4, zxy5, pk_corp
                 };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                MESIFDataSet.SteelTreasuryDataTable table = (MESIFDataSet.SteelTreasuryDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new MESIFDataSet.SteelTreasuryDataTable();
            }

            [DebuggerNonUserCode]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(MESIFDataSet.SteelTreasuryRow);
            }

            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                MESIFDataSet set = new MESIFDataSet();
                xs.Add(set.GetSchemaSerializable());
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = 1M;
                any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                attribute.Name = "namespace";
                attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "SteelTreasuryDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                return type;
            }

            [DebuggerNonUserCode]
            private void InitClass()
            {
                this.columncinventoryid = new DataColumn("cinventoryid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncinventoryid);
                this.columninvcode = new DataColumn("invcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvcode);
                this.columninvname = new DataColumn("invname", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvname);
                this.columninvspec = new DataColumn("invspec", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvspec);
                this.columninvtype = new DataColumn("invtype", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvtype);
                this.columndbilldate = new DataColumn("dbilldate", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndbilldate);
                this.columncoutwarehouseid = new DataColumn("coutwarehouseid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncoutwarehouseid);
                this.columncinwarehouseid = new DataColumn("cinwarehouseid", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncinwarehouseid);
                this.columnnnum = new DataColumn("nnum", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnnnum);
                this.columnnassistnum = new DataColumn("nassistnum", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnassistnum);
                this.columnzdy1 = new DataColumn("zdy1", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy1);
                this.columnzdy2 = new DataColumn("zdy2", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy2);
                this.columnzdy3 = new DataColumn("zdy3", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy3);
                this.columnzdy4 = new DataColumn("zdy4", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy4);
                this.columnzdy5 = new DataColumn("zdy5", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzdy5);
                this.columnzxy1 = new DataColumn("zxy1", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzxy1);
                this.columnzxy2 = new DataColumn("zxy2", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzxy2);
                this.columnzxy3 = new DataColumn("zxy3", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzxy3);
                this.columnzxy4 = new DataColumn("zxy4", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzxy4);
                this.columnzxy5 = new DataColumn("zxy5", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnzxy5);
                this.columnpk_corp = new DataColumn("pk_corp", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnpk_corp);
                base.Constraints.Add(new UniqueConstraint("SteelTreasuryKey1", new DataColumn[] { this.columncinventoryid, this.columncoutwarehouseid, this.columncinwarehouseid, this.columnpk_corp }, false));
                this.columncinventoryid.MaxLength = 0xff;
                this.columninvcode.MaxLength = 0xff;
                this.columninvname.MaxLength = 0xff;
                this.columninvspec.MaxLength = 0xff;
                this.columninvtype.MaxLength = 0xff;
                this.columndbilldate.MaxLength = 0xff;
                this.columncoutwarehouseid.MaxLength = 0xff;
                this.columncinwarehouseid.MaxLength = 0xff;
                this.columnzdy1.MaxLength = 0xff;
                this.columnzdy2.MaxLength = 0xff;
                this.columnzdy3.MaxLength = 0xff;
                this.columnzdy4.MaxLength = 0xff;
                this.columnzdy5.MaxLength = 0xff;
                this.columnzxy1.MaxLength = 0xff;
                this.columnzxy2.MaxLength = 0xff;
                this.columnzxy3.MaxLength = 0xff;
                this.columnzxy4.MaxLength = 0xff;
                this.columnzxy5.MaxLength = 0xff;
                this.columnpk_corp.MaxLength = 0xff;
            }

            [DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columncinventoryid = base.Columns["cinventoryid"];
                this.columninvcode = base.Columns["invcode"];
                this.columninvname = base.Columns["invname"];
                this.columninvspec = base.Columns["invspec"];
                this.columninvtype = base.Columns["invtype"];
                this.columndbilldate = base.Columns["dbilldate"];
                this.columncoutwarehouseid = base.Columns["coutwarehouseid"];
                this.columncinwarehouseid = base.Columns["cinwarehouseid"];
                this.columnnnum = base.Columns["nnum"];
                this.columnnassistnum = base.Columns["nassistnum"];
                this.columnzdy1 = base.Columns["zdy1"];
                this.columnzdy2 = base.Columns["zdy2"];
                this.columnzdy3 = base.Columns["zdy3"];
                this.columnzdy4 = base.Columns["zdy4"];
                this.columnzdy5 = base.Columns["zdy5"];
                this.columnzxy1 = base.Columns["zxy1"];
                this.columnzxy2 = base.Columns["zxy2"];
                this.columnzxy3 = base.Columns["zxy3"];
                this.columnzxy4 = base.Columns["zxy4"];
                this.columnzxy5 = base.Columns["zxy5"];
                this.columnpk_corp = base.Columns["pk_corp"];
            }

            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new MESIFDataSet.SteelTreasuryRow(builder);
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.SteelTreasuryRow NewSteelTreasuryRow()
            {
                return (MESIFDataSet.SteelTreasuryRow) base.NewRow();
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.SteelTreasuryRowChanged != null)
                {
                    this.SteelTreasuryRowChanged(this, new MESIFDataSet.SteelTreasuryRowChangeEvent((MESIFDataSet.SteelTreasuryRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.SteelTreasuryRowChanging != null)
                {
                    this.SteelTreasuryRowChanging(this, new MESIFDataSet.SteelTreasuryRowChangeEvent((MESIFDataSet.SteelTreasuryRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.SteelTreasuryRowDeleted != null)
                {
                    this.SteelTreasuryRowDeleted(this, new MESIFDataSet.SteelTreasuryRowChangeEvent((MESIFDataSet.SteelTreasuryRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.SteelTreasuryRowDeleting != null)
                {
                    this.SteelTreasuryRowDeleting(this, new MESIFDataSet.SteelTreasuryRowChangeEvent((MESIFDataSet.SteelTreasuryRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode]
            public void RemoveSteelTreasuryRow(MESIFDataSet.SteelTreasuryRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode]
            public DataColumn cinventoryidColumn
            {
                get
                {
                    return this.columncinventoryid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn cinwarehouseidColumn
            {
                get
                {
                    return this.columncinwarehouseid;
                }
            }

            [Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn coutwarehouseidColumn
            {
                get
                {
                    return this.columncoutwarehouseid;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn dbilldateColumn
            {
                get
                {
                    return this.columndbilldate;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invcodeColumn
            {
                get
                {
                    return this.columninvcode;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invnameColumn
            {
                get
                {
                    return this.columninvname;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invspecColumn
            {
                get
                {
                    return this.columninvspec;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn invtypeColumn
            {
                get
                {
                    return this.columninvtype;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.SteelTreasuryRow this[int index]
            {
                get
                {
                    return (MESIFDataSet.SteelTreasuryRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode]
            public DataColumn nassistnumColumn
            {
                get
                {
                    return this.columnnassistnum;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn nnumColumn
            {
                get
                {
                    return this.columnnnum;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn pk_corpColumn
            {
                get
                {
                    return this.columnpk_corp;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy1Column
            {
                get
                {
                    return this.columnzdy1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy2Column
            {
                get
                {
                    return this.columnzdy2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy3Column
            {
                get
                {
                    return this.columnzdy3;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy4Column
            {
                get
                {
                    return this.columnzdy4;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zdy5Column
            {
                get
                {
                    return this.columnzdy5;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zxy1Column
            {
                get
                {
                    return this.columnzxy1;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zxy2Column
            {
                get
                {
                    return this.columnzxy2;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zxy3Column
            {
                get
                {
                    return this.columnzxy3;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zxy4Column
            {
                get
                {
                    return this.columnzxy4;
                }
            }

            [DebuggerNonUserCode]
            public DataColumn zxy5Column
            {
                get
                {
                    return this.columnzxy5;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class SteelTreasuryRow : DataRow
        {
            private MESIFDataSet.SteelTreasuryDataTable tableSteelTreasury;

            [DebuggerNonUserCode]
            internal SteelTreasuryRow(DataRowBuilder rb) : base(rb)
            {
                this.tableSteelTreasury = (MESIFDataSet.SteelTreasuryDataTable) base.Table;
            }

            [DebuggerNonUserCode]
            public bool IscinventoryidNull()
            {
                return base.IsNull(this.tableSteelTreasury.cinventoryidColumn);
            }

            [DebuggerNonUserCode]
            public bool IscinwarehouseidNull()
            {
                return base.IsNull(this.tableSteelTreasury.cinwarehouseidColumn);
            }

            [DebuggerNonUserCode]
            public bool IscoutwarehouseidNull()
            {
                return base.IsNull(this.tableSteelTreasury.coutwarehouseidColumn);
            }

            [DebuggerNonUserCode]
            public bool IsdbilldateNull()
            {
                return base.IsNull(this.tableSteelTreasury.dbilldateColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvcodeNull()
            {
                return base.IsNull(this.tableSteelTreasury.invcodeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvnameNull()
            {
                return base.IsNull(this.tableSteelTreasury.invnameColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvspecNull()
            {
                return base.IsNull(this.tableSteelTreasury.invspecColumn);
            }

            [DebuggerNonUserCode]
            public bool IsinvtypeNull()
            {
                return base.IsNull(this.tableSteelTreasury.invtypeColumn);
            }

            [DebuggerNonUserCode]
            public bool IsnassistnumNull()
            {
                return base.IsNull(this.tableSteelTreasury.nassistnumColumn);
            }

            [DebuggerNonUserCode]
            public bool IsnnumNull()
            {
                return base.IsNull(this.tableSteelTreasury.nnumColumn);
            }

            [DebuggerNonUserCode]
            public bool Ispk_corpNull()
            {
                return base.IsNull(this.tableSteelTreasury.pk_corpColumn);
            }

            [DebuggerNonUserCode]
            public bool Iszdy1Null()
            {
                return base.IsNull(this.tableSteelTreasury.zdy1Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy2Null()
            {
                return base.IsNull(this.tableSteelTreasury.zdy2Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy3Null()
            {
                return base.IsNull(this.tableSteelTreasury.zdy3Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy4Null()
            {
                return base.IsNull(this.tableSteelTreasury.zdy4Column);
            }

            [DebuggerNonUserCode]
            public bool Iszdy5Null()
            {
                return base.IsNull(this.tableSteelTreasury.zdy5Column);
            }

            [DebuggerNonUserCode]
            public bool Iszxy1Null()
            {
                return base.IsNull(this.tableSteelTreasury.zxy1Column);
            }

            [DebuggerNonUserCode]
            public bool Iszxy2Null()
            {
                return base.IsNull(this.tableSteelTreasury.zxy2Column);
            }

            [DebuggerNonUserCode]
            public bool Iszxy3Null()
            {
                return base.IsNull(this.tableSteelTreasury.zxy3Column);
            }

            [DebuggerNonUserCode]
            public bool Iszxy4Null()
            {
                return base.IsNull(this.tableSteelTreasury.zxy4Column);
            }

            [DebuggerNonUserCode]
            public bool Iszxy5Null()
            {
                return base.IsNull(this.tableSteelTreasury.zxy5Column);
            }

            [DebuggerNonUserCode]
            public void SetcinventoryidNull()
            {
                base[this.tableSteelTreasury.cinventoryidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetcinwarehouseidNull()
            {
                base[this.tableSteelTreasury.cinwarehouseidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetcoutwarehouseidNull()
            {
                base[this.tableSteelTreasury.coutwarehouseidColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetdbilldateNull()
            {
                base[this.tableSteelTreasury.dbilldateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvcodeNull()
            {
                base[this.tableSteelTreasury.invcodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvnameNull()
            {
                base[this.tableSteelTreasury.invnameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvspecNull()
            {
                base[this.tableSteelTreasury.invspecColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetinvtypeNull()
            {
                base[this.tableSteelTreasury.invtypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetnassistnumNull()
            {
                base[this.tableSteelTreasury.nassistnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void SetnnumNull()
            {
                base[this.tableSteelTreasury.nnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setpk_corpNull()
            {
                base[this.tableSteelTreasury.pk_corpColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy1Null()
            {
                base[this.tableSteelTreasury.zdy1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy2Null()
            {
                base[this.tableSteelTreasury.zdy2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy3Null()
            {
                base[this.tableSteelTreasury.zdy3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy4Null()
            {
                base[this.tableSteelTreasury.zdy4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzdy5Null()
            {
                base[this.tableSteelTreasury.zdy5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzxy1Null()
            {
                base[this.tableSteelTreasury.zxy1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzxy2Null()
            {
                base[this.tableSteelTreasury.zxy2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzxy3Null()
            {
                base[this.tableSteelTreasury.zxy3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzxy4Null()
            {
                base[this.tableSteelTreasury.zxy4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public void Setzxy5Null()
            {
                base[this.tableSteelTreasury.zxy5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            public string cinventoryid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.cinventoryidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“cinventoryid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.cinventoryidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string cinwarehouseid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.cinwarehouseidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“cinwarehouseid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.cinwarehouseidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string coutwarehouseid
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.coutwarehouseidColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“coutwarehouseid”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.coutwarehouseidColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string dbilldate
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.dbilldateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“dbilldate”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.dbilldateColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invcode
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.invcodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“invcode”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.invcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invname
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.invnameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“invname”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.invnameColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invspec
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.invspecColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“invspec”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.invspecColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string invtype
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.invtypeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“invtype”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.invtypeColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public int nassistnum
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tableSteelTreasury.nassistnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“nassistnum”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableSteelTreasury.nassistnumColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public double nnum
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tableSteelTreasury.nnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“nnum”的值为 DBNull。", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tableSteelTreasury.nnumColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string pk_corp
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.pk_corpColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“pk_corp”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.pk_corpColumn] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy1
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.zdy1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“zdy1”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.zdy1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy2
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.zdy2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“zdy2”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.zdy2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy3
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.zdy3Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“zdy3”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.zdy3Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy4
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.zdy4Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“zdy4”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.zdy4Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zdy5
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.zdy5Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“zdy5”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.zdy5Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zxy1
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.zxy1Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“zxy1”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.zxy1Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zxy2
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.zxy2Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“zxy2”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.zxy2Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zxy3
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.zxy3Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“zxy3”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.zxy3Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zxy4
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.zxy4Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“zxy4”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.zxy4Column] = value;
                }
            }

            [DebuggerNonUserCode]
            public string zxy5
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tableSteelTreasury.zxy5Column];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("表“SteelTreasury”中列“zxy5”的值为 DBNull。", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tableSteelTreasury.zxy5Column] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class SteelTreasuryRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private MESIFDataSet.SteelTreasuryRow eventRow;

            [DebuggerNonUserCode]
            public SteelTreasuryRowChangeEvent(MESIFDataSet.SteelTreasuryRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode]
            public MESIFDataSet.SteelTreasuryRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        public delegate void SteelTreasuryRowChangeEventHandler(object sender, MESIFDataSet.SteelTreasuryRowChangeEvent e);
    }
}

