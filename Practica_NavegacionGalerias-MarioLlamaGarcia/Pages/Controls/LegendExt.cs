using Syncfusion.Maui.Toolkit.Charts;

namespace Practica_NavegacionGalerias_MarioLlamaGarcia.Pages.Controls
{
    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.5;
        }
    }
}
