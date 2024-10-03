using SkapaSchema.Entiteter;

namespace SkapaSchema.Datalager
{
    public class SchemaRepository
    {
        private Databas databas;
        public SchemaRepository() 
        {
            databas = Databas.Instans;
        }


        public List<Schema> HämtaAllaScheman()
        {
            return databas.HämtaAllaScheman();
        }
        public List<Utbildning> HämtaAllaUtbildningar()
        {
            return databas.HämtaAllaUtbildningar();
        }
        public List<person> HämtaAllaPersoner()
        {
            return databas.HämtaAllaPersoner();
        }
        public Schema SkapaSchema()
        {
            return new(); //fyll i parametrar
        }

        public void VisaSchema(Schema schema) { }

        public void TaBortSchema(Schema schema) { }

        public Schema UppdateraSchema(Schema schema) { return new(); }
        public ExaminationsMoment SkapaExaminationsMoment()
        {
            return new(); //fyll i parametrar
        }

    }
}
