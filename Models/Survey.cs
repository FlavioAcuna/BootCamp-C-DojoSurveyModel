#pragma warning disable CS8618

namespace DojoSurveyModel.Models;
public class Survey
{
    public string Nombre { get; set; }
    public string UbicacionDojo { get; set; }
    public string FavoriteLanguage { get; set; }
    public string? Comment { get; set; }
}