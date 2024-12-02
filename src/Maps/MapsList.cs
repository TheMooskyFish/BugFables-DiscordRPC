using System;
using System.Collections.Generic;
namespace RPCPlugin.Maps
{
    public class MapsClass
    {
        public static string[] Maps = [
            "Test Room", //TestRoom
            "Near Snakemouth Gate", //NearSnakemouth
            "Outside Snakemouth Den", //OutsideSnakemouth
            "Ant Kingdom Tunnels", //AntTunnels
            "Lost Sands Entrance", //DesertEntrance
            "Lost Sands Badlands", //DesertBadlands
            "Lost Sands Book Area", //DesertBookArea
            "Lost Sands Rock Formation", //DesertRockFormation
            "Lost Sands Trench South", //DesertTrenchSouth
            "Ant Kingdom Main Plaza", //BugariaMainPlaza
            "Ant Kingdom Commercial Area", //BugariaCommercial
            "Snakemouth Den Bridge", //SnakemouthBridgeRoom
            "Snakemouth Den Door", //SnakemouthDoorRoom
            "Snakemouth Den Fall", //SnakemouthFallRoom
            "Snakemouth Den Lake", //SnakemouthLake
            "Snakemouth Den Empty", //SnakemouthEmpty
            "Explorers' Association", //BugariaOutskirtsOutsideCity
            "Outside Snakemouth Den Corridor", //BugariaOutskitsSnakemouthCorridor1
            "Outside Snakemouth Den Corridor", //BugariaOutskirtsSnakemouthCorridor2
            "Snakemouth Den Underground Door", //SnakemouthUndergrondDoor
            "Snakemouth Den Mushroom Pit", //SnakemouthMushroomPit
            "Snakemouth Den Treasure", //SnakemouthTreasureRoom
            "Snakemouth Den Underground", //SnakemouthUndergroundRightA
            "Snakemouth Den Underground", //SnakemouthUndergroundRightB
            "Snakemouth Den Underground", //SnakemouthUndergroundLeftA
            "Snakemouth Den Underground", //SnakemouthUndergroundLeftB
            "Ant Kingdom Theater", //BugariaTheater
            "Chuck's Abode", //ChucksAbode
            "Ant Kingdom Residential Area", //BugariaResidential
            "Golden Path Cable Car", //GoldenHillsCableCar
            "Underground Tavern", //UndergroundBar
            "Ant Kingdom Palace", //AntPalace1
            "Ant Kingdom Throne", //AntPalace2
            "Ant Kingdom Bridge", //AntBridge
            "Ant Kingdom Palace Library", //AntPalaceLibrary
            "Golden Path Tunnel", //GoldenPathTunnel
            "Outside Golden Path Tunnel", //BOGoldenPath
            "Ant Kingdom Palace War Room", //AntPalaceWarRoom
            "Golden Path", //GoldenHillsPath2
            "Golden Settlement Entrance", //GoldenSettlementEntrance
            "Golden Settlement", //GoldenSettlement1
            "Golden Settlement Night", //GoldenSettlement1Night
            "Golden Settlement", //GoldenSettlement2
            "Golden Settlement Night", //GoldenSettlement2Night
            "Golden Path", //GoldenHillsPath3
            "Golden Hills Dungeon", //GoldenHillsDungeonEntrance
            "Golden Hills Dungeon", //GoldenHillsDungeonLeftMain
            "Golden Hills Dungeon", //GoldenHillsDungeonCrankLeft
            "Golden Hills Dungeon", //GoldenHillsDungeonRightCrank
            "Golden Hills Dungeon", //GoldenHillsLowerRightCrank
            "Golden Hills Dungeon", //GoldenHillsDungeonLeftCrankHalf
            "Golden Hills Dungeon", //GoldenHillsDungeonUpperMain
            "Golden Hills Dungeon", //GoldenHillsDungeonUpperSide
            "Venus's Garden Area", //GoldenHillsDungeonBoss
            "Bugaria Pier", //BugariaPier
            "Bugaria Outskirts East", //BugariaOutskirtsEast1
            "Bugaria Outskirts East", //BugariaOutskirtsEast2
            "Lost Sands Gate", //BOLostSandsEntrance
            "Defiant Root", //DefiantRoot1
            "Defiant Root Well", //DefiantRootWell
            "Defiant Root", //DefiantRoot2
            "Defiant Root", //DefiantRoot3
            "Bee Kingdom Outside", //BeehiveOutside
            "Bee Kingdom Throne", //BeehiveThroneRoom
            "Bee Kingdom Scanner", //BeehiveScannerRoom
            "Golden Settlement", //GoldenSettlement3
            "Golden Settlement Night", //GoldenSettlement3Night
            "Bee Kingdom Main Area", //BeehiveMainArea
            "HB's Lab", //HBsLab
            "Bee Kingdom Balcony", //BeehiveBalcony
            "Honeycomb's Lab", //HoneycombsLab
            "Jaune's Gallery", //JaunesGallery
            "Honey Factory", //HoneyFactoryEntrance
            "Ant Mines Break Room", //AntMinesBreakRoom
            "Honey Factory Worker Rooms", //HoneyFactoryWorkerRooms
            "Honey Factory Core", //HoneyFactoryCore
            "Defiant Root East Entrance", //DesertDREastEntrance
            "Lost Sands Far Grasslands Gate", //DesertFGBorder
            "Defiant Root South Entrance", //DesertDRSouthEntrance
            "Lost Sands Badge Alcove", //DesertBadgeAlcove
            "Lost Sands Caravan", //DesertCaravanMap
            "Lost Sands Sand Pit", //DesertSandPitArea
            "Lost Sands Near Golden Settlement", //DesertBeforeGH
            "Factory Processing", //FactoryProcessingFirstRoom
            "Factory Processing", //FactoryProcessing2
            "Factory Processing Pump", //FactoryProcessingPump
            "Factory Processing Puzzle", //FactoryProcessingPuzzle1
            "Factory Processing Puzzle", //FactoryProcessingPuzzle2
            "Factory Processing Puzzle", //FactoryProcessingPuzzle3
            "Factory Processing Pump", //FactoryProcessingMalbee
            "Factory Storage Maze", //FactoryStorageMaze
            "Factory Storage Elevator", //FactoryStorageElevator
            "Factory Storage", //FactoryStorageMiniboss
            "Factory Storage", //FactoryStorageOverseer
            "Metal Island", //MetalIsland1
            "Lost Sands Roach Village", //DesertRoachVillage
            "Lost Sands Oasis", //DesertOasis
            "Lost Sands Oasis Entrance", //DesertOasisEntrance
            "Lost Sands West Dunes", //DesertWestDunes
            "Bandit Hideout Entrance", //HideoutEntrance
            "Bandit Hideout Prison", //HideoutCell
            "Bandit Hideout Central Room", //HideoutCentralRoom
            "Bandit Hideout Left Side", //HideoutLeftA
            "Bandit Hideout Bridge", //HideoutStairsRoom
            "Bandit Hideout Garden", //HideoutGarden
            "Bandit Hideout Storage", //HideoutWestStorage
            "Bandit Hideout Right Side", //HideoutRightA
            "Lost Sands Sand Castle", //DesertSandCastle
            "Lost Sands Mountain", //DesertMountain
            "Lost Sands Trench Middle", //DesertTrenchMiddle
            "Lost Sands Jump Puzzle", //DesertJumpPuzzle
            "Lost Sands Southern", //DesertSouthern
            "Lost Sands Scorpion", //DesertScorpion
            "Lost Sands Eastmost", //DesertEastmost
            "Whack-a-Worm Area", //GoldenSMinigame
            "Unknown", //Blank
            "Sand Castle Entrance", //SandCastleEntrance
            "Sand Castle Slide Puzzle", //SandCastleSlidePuzzle
            "Sand Castle Statue Room", //SandCastleStatueRoom
            "Sand Castle Basement", //SandCastleBasement
            "Sand Castle Roof", //SandCastleRoof
            "Sand Castle Main Room", //SandCastleMainRoom
            "Sand Castle Key Room", //SandCastleBossKeyRoom
            "Ant Kingdom Main Plaza", //BugariaPlazaAttack //NOTFINAL
            "Ant Kingdom Bridge", //BugariaBridgeAttack //NOTFINAL
            "Ant Kingdom Palace", //BugariaCastleAttack //NOTFINAL
            "Sand Castle Pressure Puzzle", //SandCastlePressurePuzzle
            "Sand Castle Rock Room", //SandCastleRockRoom
            "Sand Castle Boss Room", //SandCastleBossRoom
            "Sand Castle Treasure Room", //SandCastleTreasureRoom
            "Explorers' Association", //BugariaAssociationAttack
            "Metal Island", //MetalIsland2
            "Stream Mountain", //StreamMountain1
            "Stream Mountain", //StreamMountain2
            "Stream Mountain", //StreamMountain3
            "Far Grasslands Cave", //FGCave
            "Seedling Haven", //SeedlingHaven
            "Far Grasslands", //FarGrasslands1
            "Far Grasslands Outside Cave", //FarGrasslandsOutsideCave
            "Far Grasslands Wizard", //FarGrasslandsWizard
            "Far Grasslands", //FarGrasslands2
            "Far Grasslands Lake", //FarGrasslandsLake
            "Far Grasslands Outside Village", //FarGrasslandsOutsideVillage
            "Far Grasslands", //FarGrasslands3
            "Fishing Village", //FishingVillage
            "Wild Swamplands Entrance", //SwamplandsEntrance
            "Wild Swamplands Outside", //FGOutsideSwamplands
            "Wasp Kingdom Outside", //WaspKingdomOutside
            "Wild Swamplands", //Swamplands2
            "Forsaken Lands Entrance", //BarrenLandsEntrance
            "Forsaken Lands CD", //BarrenLandsCD
            "Wild Swamplands", //Swamplands3
            "Wild Swamplands Bridge", //SwamplandsBridge
            "Far Grasslands", //FarGrasslands4
            "Wild Swamplands Boss", //SwamplandsBoss
            "Chomper Caves", //ChomperCave1
            "Chomper Caves", //ChomperCaves2
            "Chomper Caves", //ChomperCaves3
            "Wild Swamplands", //Swamplands4
            "Wild Swamplands", //Swamplands5
            "Wild Swamplands", //Swamplands6
            "Wild Swamplands", //Swamplands7
            "Wild Swamplands", //Swamplands8
            "Wasp Kingdom Pots", //WaspKingdom1
            "Wasp Kingdom Plaza", //WaspKingdom2
            "Wasp Kingdom", //WaspKingdom3
            "Wasp Kingdom", //WaspKingdom4
            "Wasp Kingdom Food Storage", //WaspKingdom5
            "Wasp Kingdom Prison", //WaspKingdomPrison
            "Wasp Kingdom Jayde's Room", //WaspKingdomJayde
            "Wasp Kingdom Main Hall", //WaspKingdomMainHall
            "Wasp Kingdom Throne", //WaspKingdomThrone
            "Wasp Queen's Chambers", //WaspKingdomQueen
            "Termite Kingdom Entrance", //TermiteOutside
            "Termite Kingdom Main Plaza", //TermiteMainPlaza
            "Termite Kingdom Throne", //TermiteRoyalChamber
            "Termite Kingdom Industrial", //TermiteIndustrial
            "Termite Kingdom Pier", //TermitePier
            "Termite Kingdom Coliseum", //TermiteColiseum1
            "Termite Kingdom Coliseum", //TermiteColiseum2
            "Forsaken Lands", //BarrenLandsBeefly
            "Forsaken Lands Ant Tunnel", //BarrenLandsAntTunnel
            "Forsaken Lands", //BarrenLandsMiniboss
            "Metal Lake", //MetalLake
            "Snakemouth Den Top", //SnakemouthTop
            "Cave Of Trials", //CaveOfTrials
            "Wizard Tower Basement", //WizardTowerBasement
            "Wizard Tower Stairs", //WizardTowerStairs
            "Wizard Tower Attic", //WizardTowerAttic
            "Forsaken Lands Pink Spider", //BarrenLandsPinkSpider
            "Forsaken Lands Tanks", //BarrenLandsTanks
            "Forsaken Lands Mushrooms", //BarrenLandsMushrooms
            "Ancient City", //AbandonedCity
            "Forsaken Lands Pumpkins", //BarrenLandsPumpkins
            "Forsaken Lands Pipes", //BarrenLandsCloud
            "Forsaken Lands Rock", //BarrenLandsRock
            "Ancient City Tent", //AbandonedCityTent
            "Power Plant", //PowerPlant
            "Broodmother's Lair", //BroodmotherLair
            "Forsaken Lands", //BarrenLandsSideGPT
            "Golden Path Tunnel", //GoldenPathTunnel2
            "Far Grasslands Clearing", //FGClearing
            "Stream Mountain", //StreamMountain4
            "Golden Pitcher", //GoldenPitcher1
            "Stream Mountain", //StreamMountain5
            "Golden Pitcher", //GoldenPitcher2
            "Peacock Island", //MysteryIsland
            "Peacock Island Inside", //MysteryIslandInside
            "Snakemouth Lab Entrance", //UpperSnekEntrance
            "Snakemouth Lab Transition", //UpperSnekTransition
            "Snakemouth Lab Switch Puzzle", //UpperSnekSwitchPuzzle
            "Snakemouth Lab", //UpperSnekBeforeBoss
            "Snakemouth Lab Pressure Plate", //UpperSnekPressurePlateRoom
            "Snakemouth Lab Boss", //UpperSnekBossRoom
            "Snakemouth Lab Middle", //UpperSnekMiddleRoom
            "Snakemouth Lab Platform", //UpperSnekPlatformRoom
            "Snakemouth Lab River Puzzle", //UpperSnekRiverPuzzle
            "Snakemouth Lab Geizer", //UpperSnekGeizerRoom
            "Rubber Prison Pier", //RubberPrisonPier
            "Rubber Prison Checkpoint Corridor", //RubberPrisonCheckpointCorridor
            "Rubber Prison Spike Room", //RubberPrisonSpikeRoom
            "Rubber Prison Cells", //RubberPrisonCells1
            "Rubber Prison Cells", //RubberPrisonCells2
            "Rubber Prison Library", //RubberPrisonLibrary
            "Rubber Prison Cafeteria", //RubberPrisonCafeteria
            "Rubber Prison Gym", //RubberPrisonGym
            "Rubber Prison Security", //RubberPrisonSecurity
            "Hermit Cave", //HermitCave
            "Metal Island Auditorium", //MetalIslandAuditorium
            "Rubber Prison Office", //RubberPrisonOffice
            "Rubber Prison Third Floor", //RubberPrisonThirdFloor
            "Rubber Prison Giant Lair Bridge", //RubberPrisonGiantLairBridge
            "Giant's Lair Entrance", //GiantLairEntrance
            "Giant's Lair Dead Lands", //GiantLairDeadLands1
            "Giant's Lair Dead Lands", //GiantLairDeadLands2
            "Giant's Lair Fridge Outside", //GiantLairFridgeOutside
            "Giant's Lair Fridge Inside", //GiantLairFridgeInside
            "Giant's Lair Roach Village", //GiantLairRoachVillage
            "Giant's Lair Sapling Plains", //GiantLairSaplingPlains
            "Pitcher Plant Boss", //PitcherPlantArena
            "Ant Kingdom Main Plaza", //BugariaEndPlaza
            "Ant Kingdom Bridge", //BugariaEndBridge
            "Ant Kingdom Throne", //BugariaEndThrone
            "Wasp Kingdom Drill Room", //WaspKingdomDrillRoom
            "Giant's Lair Stove", //GiantLairBeforeBoss
            "Giant's Lair Cabinets" //GiantLairBeforeBoss
        ];
        private static Dictionary<string, string> PerMapDict = new()
        {
            {"MetalLake", "submarine"},
            {"GoldenSMinigame", "whackaworm"},
            {"MetalIslandAuditorium","spycards"},
            {"FishingVillage","fishing"},
        };
        public static string GetMapImage(int id)
        {
            var map = Enum.GetName(typeof(MainManager.Maps), id);
            if (map != null)
            {
                return PerMapDict.TryGetValue(map, out var image) ? image : "icon";
            }
            return "icon";
        }
    }   
}
