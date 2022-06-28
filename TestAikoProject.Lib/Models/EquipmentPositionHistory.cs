namespace TestAikoProject.Lib.Models
{
    public class EquipmentPositionHistory : EquipmentBase
    {
        public Guid EquipmentId { get; set; }
        public DateTime Date { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public Equipment Equipment { get; set; }
        
        public EquipmentPositionHistory(Guid equipmentId, DateTime date, double lat, double lon)
        {
            EquipmentId = equipmentId;
            Date = date;
            Lat = lat;
            Lon = lon;
        }

        public Guid GetEquipmentId()
        {
            return EquipmentId;
        }
        public void SetEquipmentId(Guid equipmentId)
        {
            EquipmentId = equipmentId;
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public void SetDate(DateTime date)
        {
            Date = date;
        }
        public double GetLat()
        {
            return Lat;
        }
        public void SetLat(double lat)
        {
            Lat = lat;
        }
        public double GetLon()
        {
            return Lon;
        }
        public void SetLon(double lon)
        {
            Lon = lon;
        }
    }
}