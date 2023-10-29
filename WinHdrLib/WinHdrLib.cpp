
// WinHdrLib.cpp : Defines the functions for the static library.
//

#include <exception>
#include "framework.h"
#include <Windows.h>
#include <HighLevelMonitorConfigurationAPI.h>



extern "C" __declspec(dllexport) bool fnIsHdrSet()
{
    HDC hdc = GetDC(NULL);
    WORD gammaRamp[3][256];
    if (GetDeviceGammaRamp(hdc, gammaRamp))
    {
        if (gammaRamp[0] != NULL && gammaRamp[1] != NULL && gammaRamp[2] != NULL)
        {
            // Windows is set for HDR
            return true;
        }
        else
        {
            // Windows is not set for HDR
            return false;
        }
    }
    else
    {
        throw std::exception(); // "Failed to get gamma ramp." << std::endl;
    }
    ReleaseDC(NULL, hdc);
}



//void fnWinHdrLib()
//{
//    // Get the handle of the primary monitor
//    HMONITOR hMonitor = MonitorFromWindow(NULL, MONITOR_DEFAULTTOPRIMARY);
//
//    // Get the monitor color space information
//    MC_COLOR_TEMPERATURE colorTemp;
//    MC_DISPLAY_TECHNOLOGY_TYPE displayTechType;
//    MC_COLOR_TEMPERATURE supportedColorTemps[10];
//    DWORD numColorTemps = 10;
//    MC_SUPPORTED_MC_FEATURES supportedMCFeatures;
//    MC_COLOR_SPACE_TYPE colorSpaceType;
//    MC_DRIVE_TYPE driveType;
//    MC_DISPLAY_PRIMARY_COLOR_COORDINATES primaryColors;
//    MC_LUMINANCE data;
//    MC_GAINS gains;
//    MC_WHITE_POINT whitePoint;
//    MC_RED_GREEN_BLUE_GAINS rgbs;
//
//    if (GetMonitorColorTemperature(hMonitor, &colorTemp) &&
//        GetMonitorDisplayAreaSize(hMonitor, &displayTechType) &&
//        GetMonitorSupportedColorTemperatures(hMonitor, &supportedMCFeatures, supportedColorTemps, &numColorTemps) &&
//        GetMonitorColorSpace(hMonitor, &colorSpaceType, &driveType, &primaryColors, &data, &gains, &whitePoint, &rgbs))
//    {
//        // Check if the monitor supports HDR
//        if (colorSpaceType == MC_COLOR_SPACE_BT2020_RGB)
//        {
//            // Set the monitor color space to HDR
//            if (SetMonitorColorSpace(hMonitor, &MC_COLOR_SPACE_DATA{ MC_COLOR_SPACE_BT2020_RGB, MC_COLOR_SPACE_SDR, MC_COLOR_SPACE_SDR, MC_COLOR_SPACE_SDR }))
//            {
//                printf("HDR turned on successfully.\n");
//            }
//            else
//            {
//                printf("Failed to turn on HDR.\n");
//            }
//        }
//        else
//        {
//            printf("The monitor does not support HDR.\n");
//        }
//    }
//    else
//    {
//        printf("Failed to get monitor information.\n");
//    }
//
//
//}
//
//
//
//
//#if 0
//int main()
//{
//    // Get the handle of the primary monitor
//    HMONITOR hMonitor = MonitorFromWindow(NULL, MONITOR_DEFAULTTOPRIMARY);
//
//    // Get the monitor color space information
//    MC_COLOR_TEMPERATURE colorTemp;
//    MC_DISPLAY_TECHNOLOGY_TYPE displayTechType;
//    MC_SUPPORTED_COLOR_TEMPERATURE supportedColorTemps[10];
//    DWORD numColorTemps = 10;
//    MC_SUPPORTED_MC_FEATURES supportedMCFeatures;
//    MC_COLOR_SPACE_TYPE colorSpaceType;
//    MC_DRIVE_TYPE driveType;
//    MC_DISPLAY_PRIMARY_COLOR_COORDINATES primaryColors;
//    MC_LUMINANCE data;
//    MC_GAINS gains;
//    MC_WHITE_POINT whitePoint;
//    MC_RED_GREEN_BLUE_GAINS rgbs;
//
//    if (GetMonitorColorTemperature(hMonitor, &colorTemp) &&
//        GetMonitorDisplayAreaSize(hMonitor, &displayTechType) &&
//        GetMonitorSupportedColorTemperatures(hMonitor, &supportedMCFeatures, supportedColorTemps, &numColorTemps) &&
//        GetMonitorColorSpace(hMonitor, &colorSpaceType, &driveType, &primaryColors, &data, &gains, &whitePoint, &rgbs))
//    {
//        // Check if the monitor supports HDR
//        if (colorSpaceType == MC_COLOR_SPACE_BT2020_RGB)
//        {
//            // Set the monitor color space to HDR
//            if (SetMonitorColorSpace(hMonitor, &MC_COLOR_SPACE_DATA{ MC_COLOR_SPACE_BT2020_RGB, MC_COLOR_SPACE_SDR, MC_COLOR_SPACE_SDR, MC_COLOR_SPACE_SDR }))
//            {
//                printf("HDR turned on successfully.\n");
//            }
//            else
//            {
//                printf("Failed to turn on HDR.\n");
//            }
//        }
//        else
//        {
//            printf("The monitor does not support HDR.\n");
//        }
//    }
//    else
//    {
//        printf("Failed to get monitor information.\n");
//    }
//
//    return 0;
//}
//
//#endif
//
