﻿/***************************************************************************
* Copyright (C) 2017, Deping Chen, cdp97531@sina.com
*
* All rights reserved.
* For permission requests, write to the publisher.
*
* This software is distributed on an "AS IS" basis, WITHOUT WARRANTY OF ANY
* KIND, either express or implied.
***************************************************************************/

public enum AcBoolean
{
    acFalse = 0,
    acTrue = 1
};

public enum AcOnOff
{
    acOff = 0,
    acOn = 1
};

public enum AcEntityName
{
    ac3dFace = 1,
    ac3dPolyline = 2,
    ac3dSolid = 3,
    acArc = 4,
    acAttribute = 5,
    acAttributeReference = 6,
    acBlockReference = 7,
    acCircle = 8,
    acDimAligned = 9,
    acDimAngular = 10,
    acDimDiametric = 12,
    acDimOrdinate = 13,
    acDimRadial = 14,
    acDimRotated = 15,
    acEllipse = 16,
    acHatch = 17,
    acLeader = 18,
    acLine = 19,
    acMtext = 21,
    acPoint = 22,
    acPolyline = 23,
    acPolylineLight = 24,
    acPolymesh = 25,
    acRaster = 26,
    acRay = 27,
    acRegion = 28,
    acShape = 29,
    acSolid = 30,
    acSpline = 31,
    acText = 32,
    acTolerance = 33,
    acTrace = 34,
    acPViewport = 35,
    acXline = 36,
    acGroup = 37,
    acMInsertBlock = 38,
    acPolyfaceMesh = 39,
    acMLine = 40,
    acDim3PointAngular = 41,
    acExternalReference = 42
};

public enum AcActiveSpace
{
    acPaperSpace = 0,
    acModelSpace = 1
};

public enum AcKeyboardAccelerator
{
    acPouterenceClassic = 0,
    acPouterenceCustom = 1
};

public enum AcPlotOrientation
{
    acPlotOrientationPortrait = 0,
    acPlotOrientationLandscape = 1
};

public enum AcColor
{
    acByBlock = 0,
    acRed = 1,
    acYellow = 2,
    acGreen = 3,
    acCyan = 4,
    acBlue = 5,
    acMagenta = 6,
    acWhite = 7,
    acByLayer = 256
};

public enum AcAttachmentPoint
{
    acAttachmentPointTopLeft = 1,
    acAttachmentPointTopCenter = 2,
    acAttachmentPointTopRight = 3,
    acAttachmentPointMiddleLeft = 4,
    acAttachmentPointMiddleCenter = 5,
    acAttachmentPointMiddleRight = 6,
    acAttachmentPointBottomLeft = 7,
    acAttachmentPointBottomCenter = 8,
    acAttachmentPointBottomRight = 9
};

public enum AcDrawingDirection
{
    acLeftToRight = 1,
    acRightToLeft = 2,
    acTopToBottom = 3,
    acBottomToTop = 4,
    acByStyle = 5
};

public enum AcLeaderType
{
    acLineNoArrow = 0,
    acSplineNoArrow = 1,
    acLineWithArrow = 2,
    acSplineWithArrow = 3
};

public enum AcHorizontalAlignment
{
    acHorizontalAlignmentLeft = 0,
    acHorizontalAlignmentCenter = 1,
    acHorizontalAlignmentRight = 2,
    acHorizontalAlignmentAligned = 3,
    acHorizontalAlignmentMiddle = 4,
    acHorizontalAlignmentFit = 5
};

public enum AcVerticalAlignment
{
    acVerticalAlignmentBaseline = 0,
    acVerticalAlignmentBottom = 1,
    acVerticalAlignmentMiddle = 2,
    acVerticalAlignmentTop = 3
};

public enum AcTextGenerationFlag
{
    acTextFlagBackward = 2,
    acTextFlagUpsideDown = 4
};

public enum AcSelect
{
    acSelectionSetWindow = 0,
    acSelectionSetCrossing = 1,
    acSelectionSetFence = 2,
    acSelectionSetPrevious = 3,
    acSelectionSetLast = 4,
    acSelectionSetAll = 5,
    acSelectionSetWindowPolygon = 6,
    acSelectionSetCrossingPolygon = 7
};

public enum AcPatternType
{
    acHatchPatternTypeUserDefined = 0,
    acHatchPatternTypePreDefined = 1,
    acHatchPatternTypeCustomDefined = 2
};

public enum AcLoopType
{
    acHatchLoopTypeDefault = 0,
    acHatchLoopTypeExternal = 1,
    acHatchLoopTypePolyline = 2,
    acHatchLoopTypeDerived = 4,
    acHatchLoopTypeTextbox = 8
};

public enum AcHatchStyle
{
    acHatchStyleNormal = 0,
    acHatchStyleOuter = 1,
    acHatchStyleIgnore = 2
};

public enum AcPolylineType
{
    acSimplePoly = 0,
    acFitCurvePoly = 1,
    acQuadSplinePoly = 2,
    acCubicSplinePoly = 3
};

public enum Ac3DPolylineType
{
    acSimple3DPoly = 0,
    acQuadSpline3DPoly = 1,
    acCubicSpline3DPoly = 2
};

public enum AcViewportSplitType
{
    acViewport2Horizontal = 0,
    acViewport2Vertical = 1,
    acViewport3Left = 2,
    acViewport3Right = 3,
    acViewport3Horizontal = 4,
    acViewport3Vertical = 5,
    acViewport3Above = 6,
    acViewport3Below = 7,
    acViewport4 = 8
};

public enum AcRegenType
{
    acActiveViewport = 0,
    acAllViewports = 1
};

public enum AcBooleanType
{
    acUnion = 0,
    acIntersection = 1,
    acSubtraction = 2
};

public enum AcExtendOption
{
    acExtendNone = 0,
    acExtendThisEntity = 1,
    acExtendOtherEntity = 2,
    acExtendBoth = 3
};

public enum AcAngleUnits
{
    acDegrees = 0,
    acDegreeMinuteSeconds = 1,
    acGrads = 2,
    acRadians = 3
};

public enum AcUnits
{
    acDefaultUnits = -1,
    acScientific = 1,
    acDecimal = 2,
    acEngineering = 3,
    acArchitectural = 4,
    acFractional = 5
};

public enum AcCoordinateSystem
{
    acWorld = 0,
    acUCS = 1,
    acDisplayDCS = 2,
    acPaperSpaceDCS = 3,
    acOCS = 4
};

public enum AcMeasurementUnits
{
    acEnglish = 0,
    acMetric = 1
};

public enum AcXRefDemandLoad
{
    acDemandLoadDisabled = 0,
    acDemandLoadEnabled = 1,
    acDemandLoadEnabledWithCopy = 2
};

public enum AcPreviewMode
{
    acPartialPreview = 0,
    acFullPreview = 1
};

public enum AcPolymeshType
{
    acSimpleMesh = 0,
    acQuadSurfaceMesh = 5,
    acCubicSurfaceMesh = 6,
    acBezierSurfaceMesh = 8
};

public enum AcZoomScaleType
{
    acZoomScaledAbsolute = 0,
    acZoomScaledRelative = 1,
    acZoomScaledRelativePSpace = 2
};

public enum AcDragDisplayMode
{
    acDragDoNotDisplay = 0,
    acDragDisplayOnRequest = 1,
    acDragDisplayAutomatically = 2
};

public enum AcARXDemandLoad
{
    acDemanLoadDisable = 0,
    acDemandLoadOnObjectDetect = 1,
    acDemandLoadCmdInvoke = 2
};

public enum AcTextFontStyle
{
    acFontRegular = 0,
    acFontItalic = 1,
    acFontBold = 2,
    acFontBoldItalic = 3
};

public enum AcProxyImage
{
    acProxyNotShow = 0,
    acProxyShow = 1,
    acProxyBoundingBox = 2
};

public enum AcKeyboardPriority
{
    acKeyboardRunningObjSnap = 0,
    acKeyboardEntry = 1,
    acKeyboardEntryExceptScripts = 2
};

public enum AcMenuGroupType
{
    acBaseMenuGroup = 0,
    acPartialMenuGroup = 1
};

public enum AcMenuFileType
{
    acMenuFileCompiled = 0,
    acMenuFileSource = 1
};

public enum AcMenuItemType
{
    acMenuItem = 0,
    acMenuSeparator = 1,
    acMenuSubMenu = 2
};

public enum AcToolbarItemType
{
    acToolbarButton = 0,
    acToolbarSeparator = 1,
    acToolbarControl = 2,
    acToolbarFlyout = 3
};

public enum AcToolbarDockStatus
{
    acToolbarDockTop = 0,
    acToolbarDockBottom = 1,
    acToolbarDockLeft = 2,
    acToolbarDockRight = 3,
    acToolbarFloating = 4
};

public enum AcLineWeight
{
    acLnWt000 = 0,
    acLnWt005 = 5,
    acLnWt009 = 9,
    acLnWt013 = 13,
    acLnWt015 = 15,
    acLnWt018 = 18,
    acLnWt020 = 20,
    acLnWt025 = 25,
    acLnWt030 = 30,
    acLnWt035 = 35,
    acLnWt040 = 40,
    acLnWt050 = 50,
    acLnWt053 = 53,
    acLnWt060 = 60,
    acLnWt070 = 70,
    acLnWt080 = 80,
    acLnWt090 = 90,
    acLnWt100 = 100,
    acLnWt106 = 106,
    acLnWt120 = 120,
    acLnWt140 = 140,
    acLnWt158 = 158,
    acLnWt200 = 200,
    acLnWt211 = 211,
    acLnWtByLayer = -1,
    acLnWtByBlock = -2,
    acLnWtByLwDefault = -3
};

public enum AcWindowState
{
    acNorm = 1,
    acMin = 2,
    acMax = 3
};

public enum AcPlotPaperUnits
{
    acInches = 0,
    acMillimeters = 1,
    acPixels = 2
};

public enum AcPlotRotation
{
    ac0degrees = 0,
    ac90degrees = 1,
    ac180degrees = 2,
    ac270degrees = 3
};

public enum AcPlotType
{
    acDisplay = 0,
    acExtents = 1,
    acLimits = 2,
    acView = 3,
    acWindow = 4,
    acLayout = 5
};

public enum AcPlotScale
{
    acScaleToFit = 0,
    ac1_128in_1ft = 1,
    ac1_64in_1ft = 2,
    ac1_32in_1ft = 3,
    ac1_16in_1ft = 4,
    ac3_32in_1ft = 5,
    ac1_8in_1ft = 6,
    ac3_16in_1ft = 7,
    ac1_4in_1ft = 8,
    ac3_8in_1ft = 9,
    ac1_2in_1ft = 10,
    ac3_4in_1ft = 11,
    ac1in_1ft = 12,
    ac3in_1ft = 13,
    ac6in_1ft = 14,
    ac1ft_1ft = 15,
    ac1_1 = 16,
    ac1_2 = 17,
    ac1_4 = 18,
    ac1_8 = 19,
    ac1_10 = 20,
    ac1_16 = 21,
    ac1_20 = 22,
    ac1_30 = 23,
    ac1_40 = 24,
    ac1_50 = 25,
    ac1_100 = 26,
    ac2_1 = 27,
    ac4_1 = 28,
    ac8_1 = 29,
    ac10_1 = 30,
    ac100_1 = 31
};

public enum AcAlignment
{
    acAlignmentLeft = 0,
    acAlignmentCenter = 1,
    acAlignmentRight = 2,
    acAlignmentAligned = 3,
    acAlignmentMiddle = 4,
    acAlignmentFit = 5,
    acAlignmentTopLeft = 6,
    acAlignmentTopCenter = 7,
    acAlignmentTopRight = 8,
    acAlignmentMiddleLeft = 9,
    acAlignmentMiddleCenter = 10,
    acAlignmentMiddleRight = 11,
    acAlignmentBottomLeft = 12,
    acAlignmentBottomCenter = 13,
    acAlignmentBottomRight = 14
};

public enum AcLineSpacingStyle
{
    acLineSpacingStyleAtLeast = 1,
    acLineSpacingStyleExactly = 2
};

public enum AcDimPrecision
{
    acDimPrecisionZero = 0,
    acDimPrecisionOne = 1,
    acDimPrecisionTwo = 2,
    acDimPrecisionThree = 3,
    acDimPrecisionFour = 4,
    acDimPrecisionFive = 5,
    acDimPrecisionSix = 6,
    acDimPrecisionSeven = 7,
    acDimPrecisionEight = 8
};

public enum AcDimUnits
{
    acDimScientific = 1,
    acDimDecimal = 2,
    acDimEngineering = 3,
    acDimArchitecturalStacked = 4,
    acDimFractionalStacked = 5,
    acDimArchitectural = 6,
    acDimFractional = 7,
    acDimWindowsDesktop = 8
};

public enum AcDimLUnits
{
    acDimLScientific = 1,
    acDimLDecimal = 2,
    acDimLEngineering = 3,
    acDimLArchitectural = 4,
    acDimLFractional = 5,
    acDimLWindowsDesktop = 6
};

public enum AcDimArrowheadType
{
    acArrowDefault = 0,
    acArrowClosedBlank = 1,
    acArrowClosed = 2,
    acArrowDot = 3,
    acArrowArchTick = 4,
    acArrowOblique = 5,
    acArrowOpen = 6,
    acArrowOrigin = 7,
    acArrowOrigin2 = 8,
    acArrowOpen90 = 9,
    acArrowOpen30 = 10,
    acArrowDotSmall = 11,
    acArrowDotBlank = 12,
    acArrowSmall = 13,
    acArrowBoxBlank = 14,
    acArrowBoxFilled = 15,
    acArrowDatumBlank = 16,
    acArrowDatumFilled = 17,
    acArrowIntegral = 18,
    acArrowNone = 19,
    acArrowUserDefined = 20
};

public enum AcDimCenterType
{
    acCenterMark = 0,
    acCenterLine = 1,
    acCenterNone = 2
};

public enum AcDimFit
{
    acTextAndArrows = 0,
    acArrowsOnly = 1,
    acTextOnly = 2,
    acBestFit = 3
};

public enum AcDimFractionType
{
    acHorizontal = 0,
    acDiagonal = 1,
    acNotStacked = 2
};

public enum AcDimHorizontalJustification
{
    acHorzCentered = 0,
    acFirstExtensionLine = 1,
    acSecondExtensionLine = 2,
    acOverFirstExtension = 3,
    acOverSecondExtension = 4
};

public enum AcDimVerticalJustification
{
    acVertCentered = 0,
    acAbove = 1,
    acOutside = 2,
    acJIS = 3
};

public enum AcDimTextMovement
{
    acDimLineWithText = 0,
    acMoveTextAddLeader = 1,
    acMoveTextNoLeader = 2
};

public enum AcDimToleranceMethod
{
    acTolNone = 0,
    acTolSymmetrical = 1,
    acTolDeviation = 2,
    acTolLimits = 3,
    acTolBasic = 4
};

public enum AcDimToleranceJustify
{
    acTolBottom = 0,
    acTolMiddle = 1,
    acTolTop = 2
};

public enum AcViewportScale
{
    acVpScaleToFit = 0,
    acVpCustomScale = 1,
    acVp1_1 = 2,
    acVp1_2 = 3,
    acVp1_4 = 4,
    acVp1_8 = 5,
    acVp1_10 = 6,
    acVp1_16 = 7,
    acVp1_20 = 8,
    acVp1_30 = 9,
    acVp1_40 = 10,
    acVp1_50 = 11,
    acVp1_100 = 12,
    acVp2_1 = 13,
    acVp4_1 = 14,
    acVp8_1 = 15,
    acVp10_1 = 16,
    acVp100_1 = 17,
    acVp1_128in_1ft = 18,
    acVp1_64in_1ft = 19,
    acVp1_32in_1ft = 20,
    acVp1_16in_1ft = 21,
    acVp3_32in_1ft = 22,
    acVp1_8in_1ft = 23,
    acVp3_16in_1ft = 24,
    acVp1_4in_1ft = 25,
    acVp3_8in_1ft = 26,
    acVp1_2in_1ft = 27,
    acVp3_4in_1ft = 28,
    acVp1in_1ft = 29,
    acVp3in_1ft = 30,
    acVp6in_1ft = 31,
    acVp1ft_1ft = 32
};

public enum AcISOPenWidth
{
    acPenWidth013 = 13,
    acPenWidth018 = 18,
    acPenWidth025 = 25,
    acPenWidth035 = 35,
    acPenWidth050 = 50,
    acPenWidth070 = 70,
    acPenWidth100 = 100,
    acPenWidth140 = 140,
    acPenWidth200 = 200,
    acPenWidthUnk = -1
};

public enum AcSaveAsType
{
    acUnknown = -1,
    acR12_dxf = 1,
    acR13_dwg = 4,
    acR13_dxf = 5,
    acR14_dwg = 8,
    acR14_dxf = 9,
    acR15_dwg = 12,
    acR15_dxf = 13,
    acR15_Template = 14,
    acNative = 12
};

public enum AcPrinterSpoolAlert
{
    acPrinterAlwaysAlert = 0,
    acPrinterAlertOnce = 1,
    acPrinterNeverAlertLogOnce = 2,
    acPrinterNeverAlert = 3
};

public enum AcPlotPolicyForNewDwgs
{
    acPolicyNewDefault = 0,
    acPolicyNewLegacy = 1
};

public enum AcPlotPolicyForLegacyDwgs
{
    acPolicyLegacyDefault = 0,
    acPolicyLegacyQuery = 1,
    acPolicyLegacyLegacy = 2
};

public enum AcOleQuality
{
    acOQLineArt = 0,
    acOQText = 1,
    acOQGraphics = 2,
    acOQPhoto = 3,
    acOQHighPhoto = 4
};

public enum AcLoadPalette
{
    acPaletteByDrawing = 0,
    acPaletteBySession = 1
};

public enum AcInsertUnits
{
    acInsertUnitsUnitless = 0,
    acInsertUnitsInches = 1,
    acInsertUnitsFeet = 2,
    acInsertUnitsMiles = 3,
    acInsertUnitsMillimeters = 4,
    acInsertUnitsCentimeters = 5,
    acInsertUnitsMeters = 6,
    acInsertUnitsKilometers = 7,
    acInsertUnitsMicroinches = 8,
    acInsertUnitsMils = 9,
    acInsertUnitsYards = 10,
    acInsertUnitsAngstroms = 11,
    acInsertUnitsNanometers = 12,
    acInsertUnitsMicrons = 13,
    acInsertUnitsDecimeters = 14,
    acInsertUnitsDecameters = 15,
    acInsertUnitsHectometers = 16,
    acInsertUnitsGigameters = 17,
    acInsertUnitsAstronomicalUnits = 18,
    acInsertUnitsLightYears = 19,
    acInsertUnitsParsecs = 20
};

public enum AcAlignmentPointAcquisition
{
    acAlignPntAcquisitionAutomatic = 0,
    acAlignPntAcquisitionShiftToAcquire = 1
};

public enum AcInsertUnitsAction
{
    acInsertUnitsPrompt = 0,
    acInsertUnitsAutoAssign = 1
};

public enum AcPlotPolicy
{
    acPolicyNamed = 0,
    acPolicyLegacy = 1
};

public enum AcDrawingAreaShortCutMenu
{
    acNoDrawingAreaShortCutMenu = 0,
    acUseDefaultDrawingAreaShortCutMenu = 1
};

public enum AcDrawingAreaSCMDefault
{
    acRepeatLastCommand = 0,
    acSCM = 1
};

public enum AcDrawingAreaSCMEdit
{
    acEdRepeatLastCommand = 0,
    acEdSCM = 1
};

public enum AcDrawingAreaSCMCommand
{
    acEnter = 0,
    acEnableSCMOptions = 1,
    acEnableSCM = 2
};

public enum AcLayerStateMask
{
    acLsNone = 0,
    acLsOn = 1,
    acLsFrozen = 2,
    acLsLocked = 4,
    acLsPlot = 8,
    acLsNewViewport = 16,
    acLsColor = 32,
    acLsLineType = 64,
    acLsLineWeight = 128,
    acLsPlotStyle = 256,
    acLsAll = 65535
};

public enum AcTextAngleType
{
    acInsertAngle = 0,
    acHorizontalAngle = 1,
    acAlwaysRightReadingAngle = 2
};

public enum AcBlockConnectionType
{
    acConnectExtents = 0,
    acConnectBase = 1
};

public enum AcMLeaderType
{
    acStraightLeader = 1,
    acSplineLeader = 2,
    acInVisibleLeader = 0
};

public enum AcCellAlignment
{
    acInvalidAlignment = 0, // Add by deping to note that the variable has invalide value, so don't write to DXF file.
    acTopLeft = 1,
    acTopCenter = 2,
    acTopRight = 3,
    acMiddleLeft = 4,
    acMiddleCenter = 5,
    acMiddleRight = 6,
    acBottomLeft = 7,
    acBottomCenter = 8,
    acBottomRight = 9
};

public enum AcRowType
{
    acUnknownRow = 0,
    acDataRow = 1,
    acTitleRow = 2,
    acHeaderRow = 4
};

public enum AcValueDataType
{
    acUnknownDataType = 0,
    acLong = 1,
    acDouble = 2,
    acString = 4,
    acDate = 8,
    acPoint2d = 16,
    acPoint3d = 32,
    acObjectId = 64,
    acBuffer = 128,
    acResbuf = 256,
    acGeneral = 512
};

public enum AcValueUnitType
{
    acUnitless = 0,
    acUnitDistance = 1,
    acUnitAngle = 2,
    acUnitArea = 4,
    acUnitVolume = 8
};

public enum AcAttributeMode
{
    acAttributeModeNormal = 0,
    acAttributeModeInvisible = 1,
    acAttributeModeConstant = 2,
    acAttributeModeVerify = 4,
    acAttributeModePreset = 8,
    acAttributeModeLockPosition = 16,
    acAttributeModeMultipleLine = 32
};

public enum AcCellProperty
{
    acInvalidCellProperty = 0,
    acLock = 1,
    acDataType = 2,
    acDataFormat = 4,
    acRotation = 8,
    acScale = 16,
    acAlignmentProperty = 32,
    acContentColor = 64,
    acBackgroundColor = 128,
    acTextStyle = 256,
    acTextHeight = 512,
    acMarginLeft = 1024,
    acMarginTop = 2048,
    acMarginRight = 4096,
    acMarginBottom = 8192,
    acEnableBackgroundColor = 16384,
    acAutoScale = 32768,
    acMergeAll = 65536,
    acFlowDirBtoT = 131072,
    acContentLayout = 262144,
    acDataTypeAndFormat = 6,
    acContentProperties = 33662,
    acBitProperties = 245760,
    acAllCellProperties = 524287
};