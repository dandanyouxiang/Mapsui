﻿using Mapsui.Geometries;
using Mapsui.Layers;
using Mapsui.Providers;
using Mapsui.Styles;

namespace Mapsui.Tests.Common.Maps
{
    public static class PointInWorldUnits
    {
        public static Map CreateMap()
        {
            var map = new Map {Viewport = {Center = new Point(0, 0), Width = 200, Height = 100, Resolution = 0.5}};
            var features = new Features
            {
                Utilities.CreateSimplePointFeature(-20, 0, new SymbolStyle {UnitType = UnitType.Pixel}),
                Utilities.CreateSimplePointFeature(20, 0, new SymbolStyle {UnitType = UnitType.WorldUnit})
            };
            var layer = new MemoryLayer {DataSource = new MemoryProvider(features), Name = "Points in world units"};
            map.Layers.Add(layer);
            return map;
        }
    }
}