using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.DesignScript.Geometry;
using Autodesk.DesignScript.Runtime;
using Graphical.Geometry;
using Polygon = Graphical.Geometry.Polygon;
using Vertex = Graphical.Geometry.Vertex;

namespace GraphicalDynamo.Geometry
{
    public static class Polygons
    {
        #region Public Methods

        /// <summary>
        /// Method to check if a polygon contains a point.
        /// </summary>
        /// <param name="polygon"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public static bool ContainsPoint(Graphical.Geometry.Polygon polygon, Point point)
        {
            Polygon gPol = Polygon.ByVertices(polygon.Vertices.Select(p => Vertex.ByCoordinates(p.X, p.Y, p.Z)).ToList());
            Vertex vertex = Vertex.ByCoordinates(point.X, point.Y, point.Z);

            return gPol.ContainsVertex(vertex);
        }

        #endregion
    }
}
