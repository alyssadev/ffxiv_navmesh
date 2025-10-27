using System.Collections.Generic;
using System.Numerics;
using DotRecast.Detour;

namespace Navmesh.Customizations
{
    [CustomizationTerritory(1297)]
    internal class Z1297ZirgotehOpenArmed : NavmeshCustomization
    {
        public override int Version => 1;

        public override void CustomizeMesh(DtNavMesh mesh, List<uint> festivalLayers)
        {
            base.CustomizeMesh(mesh, festivalLayers);
            void Link(Vector3 A, Vector3 B)
            {
                LinkPoints(mesh, A, B);
            }
            void Links(Vector3 A, Vector3[] Bs)
            {
                foreach (Vector3 B in Bs) Link(A, B);
            }
            // Locations
            Vector3 WalkwayA1 = new(10.875303f, 0.39999998f, 171.73851f);
            Vector3 WalkwayA2 = new(11.1604805f, 0.39999998f, 132.32458f);
            Vector3 WalkwayA3 = new(14.356972f, 0f, 106.03198f);
            Vector3 WalkwayA4 = new(13.2904625f, 0.29999995f, 83.92669f);
            Vector3 WalkwayA5 = new(13.7213335f, 0.29999995f, 46.622673f);
            Vector3 WalkwayA6 = new(15.113593f, -3.8146973E-06f, 8.03874f);
            Vector3 WalkwayB1 = new(-9.157655f, 0.39999998f, 173.78545f);
            Vector3 WalkwayB2 = new(-10.262363f, 0.39999998f, 134.55086f);
            Vector3 WalkwayB3 = new(-10.562019f, 0f, 106.71826f);
            Vector3 WalkwayB4 = new(-11.4038105f, 0.29999995f, 80.29187f);
            Vector3 WalkwayB5 = new(-12.251459f, 0.29999995f, 46.22155f);
            Vector3 WalkwayB6 = new(-12.739389f, 0f, 10.487154f);
            Vector3 Entrance = new(-0.69562393f, 21.915377f, -87.20233f);
            Vector3 NWEntranceOutside = new(-53.100693f, 3.484485f, 50.768303f);
            Vector3 NWEntranceInside = new(-94.5487f, 5.9020233f, 51.550232f);
            Vector3 NEEntranceBottom = new(48.765984f, 0f, 65.6565f);
            Vector3 NEEntranceTop = new(67.48184f, 2.0006344f, 65.82045f);
            Vector3 NEEntranceInside = new(86.332504f, 3.3723085f, 66.4195f);
            Vector3 NEDetourSWcnr = new(73.174614f, 1.8905408f, 96.48147f);
            Vector3 NEDetourS = new(102.68766f, 1.8905408f, 99.068634f);
            Vector3 NEDetourSEcnr = new(128.6724f, 1.8905404f, 101.24582f);
            Vector3 NERearTop = new(160.77792f, 3.905186f, 89.96246f);
            Vector3 NERearBottom = new(160.69812f, 1.8905404f, 97.58388f);
            Vector3 NERearSW = new(151.65784f, 3.9050744f, 87.19325f);
            Vector3 NERearNW = new(153.25764f, 3.905f, 44.680065f);
            Vector3 NERearTBottom = new(161.40189f, 3.905f, 33.058224f);
            Vector3 NERearTTop = new(161.28258f, 5.8219995f, 26.653318f);
            Vector3 NERearTSW = new(99.65183f, 5.821991f, 25.496578f);
            Vector3 NERearTWTop = new(96.84151f, 5.821912f, 15.053087f);
            Vector3 NERearTWBottom = new(88.45094f, 3.8709939f, 14.46393f);
            Vector3 NERearGazebo = new(74.89003f, 3.871f, 16.309841f);
            Vector3 NNEStepsTop = new(73.54245f, 3.871f, 24.81747f);
            Vector3 NNEStepsBottom = new(73.29891f, 1.8905408f, 32.03145f);
            Vector3 SWEntranceOutside = new(-53.79512f, 1.6528156f, 160.55959f);
            Vector3 SWEntranceInside = new(-77.71528f, 4.0711737f, 160.63036f);
            Vector3 SEEntranceLeftBottom = new(67.568954f, 0f, 149.88551f);
            Vector3 SEEntranceRightBottom = new(55.7504f, 0f, 177.5805f);
            Vector3 SEEntranceLeftTop = new(81.21239f, 3.9428923f, 153.80418f);
            Vector3 SEEntranceRightTop = new(66.95687f, 3.9428923f, 184.54924f);
            Vector3 SEDetourN1 = new(101.94124f, 3.9428923f, 134.07701f);
            Vector3 SEDetourN2 = new(134.0269f, 3.9428918f, 153.745f);
            Vector3 SEDetourN3 = new(128.05264f, 3.9429266f, 176.01587f);
            Vector3 AltarNNE = new(10.836078f, 13.337913f, 240.27493f);
            Vector3 AltarNE = new(23.052216f, 13.538549f, 286.33185f);
            Vector3 AltarENE = new(47.866104f, 13.538555f, 299.1624f);
            Vector3 AltarESE = new(47.80266f, 13.538503f, 335.26614f);
            Vector3 AltarSE = new(25.434553f, 13.538559f, 348.61038f);
            Vector3 AltarSSE = new(12.841506f, 13.538559f, 355.6382f);
            Vector3 AltarSSW = new(-16.391617f, 13.538554f, 355.30072f);
            Vector3 AltarSW = new(-27.089798f, 13.538551f, 346.23425f);
            Vector3 AltarWSW = new(-47.581028f, 13.5384865f, 335.2739f);
            Vector3 AltarWNW = new(-47.093357f, 13.538542f, 300.3751f);
            Vector3 AltarNW = new(-25.201168f, 13.538543f, 288.65164f);
            Vector3 AltarNNW = new(-9.090271f, 12.772565f, 239.21193f);
            Vector3 AltarN = new(0.9756199f, 12.479787f, 238.6619f);
            Vector3 AltarStairsTop = new(0.32300267f, 38.85278f, 299.6844f);
            // NPCs
            Vector3 Xarhorkur = new(73.97587f, 1.8856397f, 52.038727f);
            // Detours
            Link(SEEntranceLeftTop,SEDetourN1);Link(SEDetourN1,SEDetourN2);Link(SEDetourN2,SEDetourN3);
            Link(NEEntranceTop,NEDetourSWcnr);Link(NEDetourSWcnr,NEDetourS);Link(NEDetourS,NEDetourSEcnr);
            Links(NEDetourSEcnr,[SEDetourN2,NERearBottom]);Link(NERearBottom,NERearTop);Link(NERearTop,NERearSW);
            Link(NERearSW,NERearNW);Link(NERearNW,NERearTBottom);Link(NERearTBottom,NERearTTop);Link(NERearTTop,NERearTSW);
            Link(NERearTSW,NERearTWTop);Link(NERearTWTop,NERearTWBottom);Link(NERearTWBottom,NERearGazebo);
            Link(NERearGazebo,NNEStepsTop);Link(NNEStepsTop,NNEStepsBottom);Link(NNEStepsBottom,Xarhorkur);
            // Middle path
            Links(WalkwayA1, [WalkwayA2,WalkwayB1,WalkwayB2,SEEntranceRightBottom,SEEntranceLeftBottom,AltarN,AltarNNE]);
            Links(WalkwayA2, [WalkwayA3,SEEntranceRightBottom,SEEntranceLeftBottom,WalkwayB1,WalkwayB2,WalkwayB3]);
            Links(WalkwayA3, [WalkwayA4,NEEntranceBottom,SEEntranceLeftBottom,WalkwayB2,WalkwayB3,WalkwayB4]);
            Links(WalkwayA4, [WalkwayA5,NEEntranceBottom,WalkwayB3,WalkwayB4,WalkwayB5]);
            Links(WalkwayA5, [WalkwayA6,NEEntranceBottom,WalkwayB4,WalkwayB5,WalkwayB6]);
            Links(WalkwayA6, [Entrance,WalkwayB5,WalkwayB6,NEEntranceBottom]);
            Links(WalkwayB1, [WalkwayB2,SWEntranceOutside]);
            Links(WalkwayB2, [WalkwayB3,SWEntranceOutside]);
            Links(WalkwayB3, [WalkwayB4,NWEntranceOutside,SWEntranceOutside]);
            Links(WalkwayB4, [WalkwayB5,NWEntranceOutside]);
            Links(WalkwayB5, [WalkwayB6,NWEntranceOutside]);
            Links(WalkwayB6, [Entrance,NWEntranceOutside]);
            // Doorways
            Link(NWEntranceOutside,NWEntranceInside);
            Link(NEEntranceBottom,NEEntranceTop);
            Links(NEEntranceTop,[Xarhorkur,NEEntranceInside]);
            Link(SWEntranceOutside,SWEntranceInside);
            Link(SEEntranceLeftBottom,SEEntranceLeftTop);
            Link(SEEntranceRightBottom,SEEntranceRightTop);
            Link(NEEntranceBottom,SEEntranceLeftBottom);
            Link(SEEntranceLeftBottom,SEEntranceRightBottom);
            Link(NERearBottom,NERearTop);
            // Altar
            Links(AltarN,[AltarNNE,AltarNNW,AltarStairsTop]);
            Link(AltarNNE,AltarNE);
            Link(AltarNE,AltarENE);
            Link(AltarENE,AltarESE);
            Link(AltarESE,AltarSE);
            Link(AltarSE,AltarSSE);
            Link(AltarSSE,AltarSSW);
            Link(AltarSSW,AltarSW);
            Link(AltarSW,AltarWSW);
            Link(AltarWSW,AltarWNW);
            Link(AltarWNW,AltarNW);
            Link(AltarNW,AltarNNW);
            
        }
    }
}