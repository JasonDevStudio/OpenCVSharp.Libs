using OpenCharts.Shapes;
using OpenCharts.Shapes.Skia;

namespace OpenCharts;

public class AddIn
{
    public void RegsisterTypes()
    {
        GlobaService.ContainerBuilder.RegisterType<CirclePointShape>().Keyed<IPointShape>(ShapeTypes.Circle).PropertiesAutowired();
        GlobaService.ContainerBuilder.RegisterType<RectangleShape>().Keyed<IPointShape>(ShapeTypes.Rectangle).PropertiesAutowired();
        GlobaService.ContainerBuilder.RegisterType<PentagramPointShape>().Keyed<IPointShape>(ShapeTypes.Pentagram).PropertiesAutowired();
        GlobaService.ContainerBuilder.RegisterType<TrianglePointShape>().Keyed<IPointShape>(ShapeTypes.Triangle).PropertiesAutowired();

        GlobaService.Container = GlobaService.ContainerBuilder.Build();
    }
}
