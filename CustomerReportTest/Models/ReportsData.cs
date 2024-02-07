namespace CustomerReportTest.Models
{

    public class Root
    {
        public Dictionary<string, Organization> Organizations { get; set; }
    }

    public class ActiveOrganization
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Organization
    {
        public string organizationId { get; set; }
        public string customerName { get; set; }
        public Dictionary<string, Farm> farms { get; set; }
    }

    public class Farm
    {
        public string id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string average_temp { get; set; }
        public string average_oxygen { get; set; }
        public string average_depth { get; set; }
        public float average_kjmhunn { get; set; }
        public float average_bevegelig { get; set; }
        public float average_weight { get; set; }
        public double high_baseline { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public Dictionary<string, Cage> cages { get; set; }
    }

    public class Cage
    {
        public string id { get; set; }
        public string serial_number { get; set; }
        public List<FishGroup> fishGroups { get; set; }
        public List<SensorInfo> SensorsInfo { get; set; }
        public List<DetailedData> DetailedData { get; set; }
    }

    public class FishGroup
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<Statistic> statistics { get; set; }
        public List<AverageData> averageData { get; set; }
    }

    public class Statistic
    {
        public string date { get; set; }
        public string oxygen { get; set; }
        public string temprature { get; set; }
        public int numberOfFishs { get; set; }
        public List<Lice> lices { get; set; }
    }

    public class Lice
    {
        public string name { get; set; }
        public double min { get; set; }
        public double average { get; set; }
        public double max { get; set; }
    }

    public class AverageData
    {
        public AverageWeight average_weight { get; set; }
        public AverageLice average_lice { get; set; }
    }

    public class AverageWeight
    {
        public int week_number { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public double average { get; set; }
    }

    public class AverageLice
    {
        public int week_number { get; set; }
        public string date_from { get; set; }
        public string date_to { get; set; }
        public List<Lice> lices { get; set; }
        public string fish_group { get; set; }
    }

    public class SensorInfo
    {
        public string id { get; set; }
        public string last_schedule_status { get; set; }
        public string serial_number { get; set; }
        public bool active { get; set; }
        public string winch { get; set; }
        public int total_fishs_today { get; set; }
        public List<ScheduleData> scheduleData { get; set; }
    }

    public class ScheduleData
    {
        public string id { get; set; }
        public string created { get; set; }
        public string operation_type { get; set; }
        public bool is_active { get; set; }
        public string positions { get; set; }
        public int period { get; set; }
        public string schedule_time { get; set; }
        public string setting { get; set; }
    }

    public class DetailedData
    {
        public string id { get; set; }
        public string organization { get; set; }
        public string farm_id { get; set; }
        public string name { get; set; }
        public CageWinchSensor cage_winch_sensor { get; set; }
        public LiceDetailedData lice { get; set; }
        public WeightDetailedData weight { get; set; }
        public EnvironmentDetailedData environment { get; set; }
    }

    public class CageWinchSensor
    {
        public string cage { get; set; }
        public float? circumference { get; set; }
        public float? depth_lead { get; set; }
        public float? depth_deepest_point { get; set; }
        public string sensor { get; set; }
        public int? winch { get; set; }
        public float? rol { get; set; }
        public float? tilt { get; set; }
        public float? x_pos { get; set; }
        public float? z_pos_deviation { get; set; }
        public float? depth { get; set; }
    }

    public class LiceDetailedData
    {
        public int? fishs_yesterday { get; set; }
        public int? fishs_today { get; set; }
        public double? kjmhunn { get; set; }
        public double? bevegelig { get; set; }
        public string last_sample_date { get; set; }
    }

    public class WeightDetailedData
    {
        public int? fishs_yesterday { get; set; }
        public int? fishs_today { get; set; }
        public double? average_weight { get; set; }
        public double? growth_rate { get; set; }
        public string last_sample_date { get; set; }
    }

    public class EnvironmentDetailedData
    {
        public float? min_depth { get; set; }
        public float? max_depth { get; set; }
        public float? min_oxygen { get; set; }
        public float? max_oxygen { get; set; }
        public float? min_temp { get; set; }
        public float? max_temp { get; set; }
    }
}

