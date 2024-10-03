using SkapaSchema.Datalager; // kan ej hitta .csproj filen 
using SkapaSchema.Entiteter;


namespace SkapaSchema.Affärslager
{
    public class SchemaKontroller
    {
        private SchemaRepository schemaRepository {  get; set; }
        public SchemaKontroller() 
        {
            schemaRepository = new SchemaRepository();


        }


        public List<Schema> HämtaAllaScheman()
        {
            return schemaRepository.HämtaAllaScheman();
        }
        public List<Utbildning> HämtaAllaUtbildningar()
        {
            return schemaRepository.HämtaAllaUtbildningar();
        }
        public List<person> HämtaAllaPersoner()
        {
            return schemaRepository.HämtaAllaPersoner();
        }
    }
}
