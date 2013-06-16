// .net port of WiaDef.h

/****************************************************************************
*
*  (C) Copyright 1998-2003, Microsoft Corp.
*
*  File:    wiadef.h
*
*  Version: 3.0
*
*  Description: WIA constant definitions
*
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DerpScan.WiaWrapper
{
    class WiaDef
    {
        //// #if (_WIN32_WINNT >= 0x0501) // Windows XP and later

        //#pragma once

        //// #ifndef _WIADEF_
        //public const int _WIADEF_


        //#include <pshpack8.h>
        //// #ifndef _NO_COM
        //#include <objbase.h>
        //// #endif

        //// #ifdef __cplusplus
        //extern "C" {
        //// #endif

        //
        // WIA property ID and string constants
        //

        public const int WIA_DIP_DEV_ID = 2; // 0x2
        public const string WIA_DIP_DEV_ID_STR = "Unique Device ID";

        public const int WIA_DIP_VEND_DESC = 3; // 0x3
        public const string WIA_DIP_VEND_DESC_STR = "Manufacturer";

        public const int WIA_DIP_DEV_DESC = 4; // 0x4
        public const string WIA_DIP_DEV_DESC_STR = "Description";

        public const int WIA_DIP_DEV_TYPE = 5; // 0x5
        public const string WIA_DIP_DEV_TYPE_STR = "Type";

        public const int WIA_DIP_PORT_NAME = 6; // 0x6
        public const string WIA_DIP_PORT_NAME_STR = "Port";

        public const int WIA_DIP_DEV_NAME = 7; // 0x7
        public const string WIA_DIP_DEV_NAME_STR = "Name";

        public const int WIA_DIP_SERVER_NAME = 8; // 0x8
        public const string WIA_DIP_SERVER_NAME_STR = "Server";

        public const int WIA_DIP_REMOTE_DEV_ID = 9; // 0x9
        public const string WIA_DIP_REMOTE_DEV_ID_STR = "Remote Device ID";

        public const int WIA_DIP_UI_CLSID = 10; // 0xa
        public const string WIA_DIP_UI_CLSID_STR = "UI Class ID";

        public const int WIA_DIP_HW_CONFIG = 11; // 0xb
        public const string WIA_DIP_HW_CONFIG_STR = "Hardware Configuration";

        public const int WIA_DIP_BAUDRATE = 12; // 0xc
        public const string WIA_DIP_BAUDRATE_STR = "BaudRate";

        public const int WIA_DIP_STI_GEN_CAPABILITIES = 13; // 0xd
        public const string WIA_DIP_STI_GEN_CAPABILITIES_STR = "STI Generic Capabilities";

        public const int WIA_DIP_WIA_VERSION = 14; // 0xe
        public const string WIA_DIP_WIA_VERSION_STR = "WIA Version";

        public const int WIA_DIP_DRIVER_VERSION = 15; // 0xf
        public const string WIA_DIP_DRIVER_VERSION_STR = "Driver Version";

        public const int WIA_DIP_PNP_ID = 16; // 0x10
        public const string WIA_DIP_PNP_ID_STR = "PnP ID String";

        public const int WIA_DIP_STI_DRIVER_VERSION = 17; // 0x11
        public const string WIA_DIP_STI_DRIVER_VERSION_STR = "STI Driver Version";

        public const int WIA_DPA_FIRMWARE_VERSION = 1026; // 0x402
        public const string WIA_DPA_FIRMWARE_VERSION_STR = "Firmware Version";

        public const int WIA_DPA_CONNECT_STATUS = 1027; // 0x403
        public const string WIA_DPA_CONNECT_STATUS_STR = "Connect Status";

        public const int WIA_DPA_DEVICE_TIME = 1028; // 0x404
        public const string WIA_DPA_DEVICE_TIME_STR = "Device Time";

        public const int WIA_DPC_PICTURES_TAKEN = 2050; // 0x802
        public const string WIA_DPC_PICTURES_TAKEN_STR = "Pictures Taken";

        public const int WIA_DPC_PICTURES_REMAINING = 2051; // 0x803
        public const string WIA_DPC_PICTURES_REMAINING_STR = "Pictures Remaining";

        public const int WIA_DPC_EXPOSURE_MODE = 2052; // 0x804
        public const string WIA_DPC_EXPOSURE_MODE_STR = "Exposure Mode";

        public const int WIA_DPC_EXPOSURE_COMP = 2053; // 0x805
        public const string WIA_DPC_EXPOSURE_COMP_STR = "Exposure Compensation";

        public const int WIA_DPC_EXPOSURE_TIME = 2054; // 0x806
        public const string WIA_DPC_EXPOSURE_TIME_STR = "Exposure Time";

        public const int WIA_DPC_FNUMBER = 2055; // 0x807
        public const string WIA_DPC_FNUMBER_STR = "F Number";

        public const int WIA_DPC_FLASH_MODE = 2056; // 0x808
        public const string WIA_DPC_FLASH_MODE_STR = "Flash Mode";

        public const int WIA_DPC_FOCUS_MODE = 2057; // 0x809
        public const string WIA_DPC_FOCUS_MODE_STR = "Focus Mode";

        public const int WIA_DPC_FOCUS_MANUAL_DIST = 2058; // 0x80a
        public const string WIA_DPC_FOCUS_MANUAL_DIST_STR = "Focus Manual Dist";

        public const int WIA_DPC_ZOOM_POSITION = 2059; // 0x80b
        public const string WIA_DPC_ZOOM_POSITION_STR = "Zoom Position";

        public const int WIA_DPC_PAN_POSITION = 2060; // 0x80c
        public const string WIA_DPC_PAN_POSITION_STR = "Pan Position";

        public const int WIA_DPC_TILT_POSITION = 2061; // 0x80d
        public const string WIA_DPC_TILT_POSITION_STR = "Tilt Position";

        public const int WIA_DPC_TIMER_MODE = 2062; // 0x80e
        public const string WIA_DPC_TIMER_MODE_STR = "Timer Mode";

        public const int WIA_DPC_TIMER_VALUE = 2063; // 0x80f
        public const string WIA_DPC_TIMER_VALUE_STR = "Timer Value";

        public const int WIA_DPC_POWER_MODE = 2064; // 0x810
        public const string WIA_DPC_POWER_MODE_STR = "Power Mode";

        public const int WIA_DPC_BATTERY_STATUS = 2065; // 0x811
        public const string WIA_DPC_BATTERY_STATUS_STR = "Battery Status";

        public const int WIA_DPC_THUMB_WIDTH = 2066; // 0x812
        public const string WIA_DPC_THUMB_WIDTH_STR = "Thumbnail Width";

        public const int WIA_DPC_THUMB_HEIGHT = 2067; // 0x813
        public const string WIA_DPC_THUMB_HEIGHT_STR = "Thumbnail Height";

        public const int WIA_DPC_PICT_WIDTH = 2068; // 0x814
        public const string WIA_DPC_PICT_WIDTH_STR = "Picture Width";

        public const int WIA_DPC_PICT_HEIGHT = 2069; // 0x815
        public const string WIA_DPC_PICT_HEIGHT_STR = "Picture Height";

        public const int WIA_DPC_DIMENSION = 2070; // 0x816
        public const string WIA_DPC_DIMENSION_STR = "Dimension";

        public const int WIA_DPC_COMPRESSION_SETTING = 2071; // 0x817
        public const string WIA_DPC_COMPRESSION_SETTING_STR = "Compression Setting";

        public const int WIA_DPC_FOCUS_METERING = 2072; // 0x818
        public const string WIA_DPC_FOCUS_METERING_STR = "Focus Metering Mode";

        public const int WIA_DPC_TIMELAPSE_INTERVAL = 2073; // 0x819
        public const string WIA_DPC_TIMELAPSE_INTERVAL_STR = "Timelapse Interva";

        public const int WIA_DPC_TIMELAPSE_NUMBER = 2074; // 0x81a
        public const string WIA_DPC_TIMELAPSE_NUMBER_STR = "Timelapse Number";

        public const int WIA_DPC_BURST_INTERVAL = 2075; // 0x81b
        public const string WIA_DPC_BURST_INTERVAL_STR = "Burst Interva";

        public const int WIA_DPC_BURST_NUMBER = 2076; // 0x81c
        public const string WIA_DPC_BURST_NUMBER_STR = "Burst Number";

        public const int WIA_DPC_EFFECT_MODE = 2077; // 0x81d
        public const string WIA_DPC_EFFECT_MODE_STR = "Effect Mode";

        public const int WIA_DPC_DIGITAL_ZOOM = 2078; // 0x81e
        public const string WIA_DPC_DIGITAL_ZOOM_STR = "Digital Zoom";

        public const int WIA_DPC_SHARPNESS = 2079; // 0x81f
        public const string WIA_DPC_SHARPNESS_STR = "Sharpness";

        public const int WIA_DPC_CONTRAST = 2080; // 0x820
        public const string WIA_DPC_CONTRAST_STR = "Contrast";

        public const int WIA_DPC_CAPTURE_MODE = 2081; // 0x821
        public const string WIA_DPC_CAPTURE_MODE_STR = "Capture Mode";

        public const int WIA_DPC_CAPTURE_DELAY = 2082; // 0x822
        public const string WIA_DPC_CAPTURE_DELAY_STR = "Capture Delay";

        public const int WIA_DPC_EXPOSURE_INDEX = 2083; // 0x823
        public const string WIA_DPC_EXPOSURE_INDEX_STR = "Exposure Index";

        public const int WIA_DPC_EXPOSURE_METERING_MODE = 2084; // 0x824
        public const string WIA_DPC_EXPOSURE_METERING_MODE_STR = "Exposure Metering Mode";

        public const int WIA_DPC_FOCUS_METERING_MODE = 2085; // 0x825
        public const string WIA_DPC_FOCUS_METERING_MODE_STR = "Focus Metering Mode";

        public const int WIA_DPC_FOCUS_DISTANCE = 2086; // 0x826
        public const string WIA_DPC_FOCUS_DISTANCE_STR = "Focus Distance";

        public const int WIA_DPC_FOCAL_LENGTH = 2087; // 0x827
        public const string WIA_DPC_FOCAL_LENGTH_STR = "Focus Length";

        public const int WIA_DPC_RGB_GAIN = 2088; // 0x828
        public const string WIA_DPC_RGB_GAIN_STR = "RGB Gain";

        public const int WIA_DPC_WHITE_BALANCE = 2089; // 0x829
        public const string WIA_DPC_WHITE_BALANCE_STR = "White Balance";

        public const int WIA_DPC_UPLOAD_URL = 2090; // 0x82a
        public const string WIA_DPC_UPLOAD_URL_STR = "Upload UR";

        public const int WIA_DPC_ARTIST = 2091; // 0x82b
        public const string WIA_DPC_ARTIST_STR = "Artist";

        public const int WIA_DPC_COPYRIGHT_INFO = 2092; // 0x82c
        public const string WIA_DPC_COPYRIGHT_INFO_STR = "Copyright Info";

        public const int WIA_DPS_HORIZONTAL_BED_SIZE = 3074; // 0xc02
        public const string WIA_DPS_HORIZONTAL_BED_SIZE_STR = "Horizontal Bed Size";

        public const int WIA_DPS_VERTICAL_BED_SIZE = 3075; // 0xc03
        public const string WIA_DPS_VERTICAL_BED_SIZE_STR = "Vertical Bed Size";

        public const int WIA_DPS_HORIZONTAL_SHEET_FEED_SIZE = 3076; // 0xc04
        public const string WIA_DPS_HORIZONTAL_SHEET_FEED_SIZE_STR = "Horizontal Sheet Feed Size";

        public const int WIA_DPS_VERTICAL_SHEET_FEED_SIZE = 3077; // 0xc05
        public const string WIA_DPS_VERTICAL_SHEET_FEED_SIZE_STR = "Vertical Sheet Feed Size";

        public const int WIA_DPS_SHEET_FEEDER_REGISTRATION = 3078; // 0xc06
        public const string WIA_DPS_SHEET_FEEDER_REGISTRATION_STR = "Sheet Feeder Registration";

        public const int WIA_DPS_HORIZONTAL_BED_REGISTRATION = 3079; // 0xc07
        public const string WIA_DPS_HORIZONTAL_BED_REGISTRATION_STR = "Horizontal Bed Registration";

        public const int WIA_DPS_VERTICAL_BED_REGISTRATION = 3080; // 0xc08
        public const string WIA_DPS_VERTICAL_BED_REGISTRATION_STR = "Vertical Bed Registration";

        public const int WIA_DPS_PLATEN_COLOR = 3081; // 0xc09
        public const string WIA_DPS_PLATEN_COLOR_STR = "Platen Color";

        public const int WIA_DPS_PAD_COLOR = 3082; // 0xc0a
        public const string WIA_DPS_PAD_COLOR_STR = "Pad Color";

        public const int WIA_DPS_FILTER_SELECT = 3083; // 0xc0b
        public const string WIA_DPS_FILTER_SELECT_STR = "Filter Select";

        public const int WIA_DPS_DITHER_SELECT = 3084; // 0xc0c
        public const string WIA_DPS_DITHER_SELECT_STR = "Dither Select";

        public const int WIA_DPS_DITHER_PATTERN_DATA = 3085; // 0xc0d
        public const string WIA_DPS_DITHER_PATTERN_DATA_STR = "Dither Pattern Data";

        public const int WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES = 3086; // 0xc0e
        public const string WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES_STR = "Document Handling Capabilities";

        public const int WIA_DPS_DOCUMENT_HANDLING_STATUS = 3087; // 0xc0f
        public const string WIA_DPS_DOCUMENT_HANDLING_STATUS_STR = "Document Handling Status";

        public const int WIA_DPS_DOCUMENT_HANDLING_SELECT = 3088; // 0xc10
        public const string WIA_DPS_DOCUMENT_HANDLING_SELECT_STR = "Document Handling Select";

        public const int WIA_DPS_DOCUMENT_HANDLING_CAPACITY = 3089; // 0xc11
        public const string WIA_DPS_DOCUMENT_HANDLING_CAPACITY_STR = "Document Handling Capacity";

        public const int WIA_DPS_OPTICAL_XRES = 3090; // 0xc12
        public const string WIA_DPS_OPTICAL_XRES_STR = "Horizontal Optical Resolution";

        public const int WIA_DPS_OPTICAL_YRES = 3091; // 0xc13
        public const string WIA_DPS_OPTICAL_YRES_STR = "Vertical Optical Resolution";

        public const int WIA_DPS_ENDORSER_CHARACTERS = 3092; // 0xc14
        public const string WIA_DPS_ENDORSER_CHARACTERS_STR = "Endorser Characters";

        public const int WIA_DPS_ENDORSER_STRING = 3093; // 0xc15
        public const string WIA_DPS_ENDORSER_STRING_STR = "Endorser String";

        public const int WIA_DPS_SCAN_AHEAD_PAGES = 3094; // 0xc16
        public const string WIA_DPS_SCAN_AHEAD_PAGES_STR = "Scan Ahead Pages";

        public const int WIA_DPS_MAX_SCAN_TIME = 3095; // 0xc17
        public const string WIA_DPS_MAX_SCAN_TIME_STR = "Max Scan Time";

        public const int WIA_DPS_PAGES = 3096; // 0xc18
        public const string WIA_DPS_PAGES_STR = "Pages";

        public const int WIA_DPS_PAGE_SIZE = 3097; // 0xc19
        public const string WIA_DPS_PAGE_SIZE_STR = "Page Size";

        public const int WIA_DPS_PAGE_WIDTH = 3098; // 0xc1a
        public const string WIA_DPS_PAGE_WIDTH_STR = "Page Width";

        public const int WIA_DPS_PAGE_HEIGHT = 3099; // 0xc1b
        public const string WIA_DPS_PAGE_HEIGHT_STR = "Page Height";

        public const int WIA_DPS_PREVIEW = 3100; // 0xc1c
        public const string WIA_DPS_PREVIEW_STR = "Preview";

        public const int WIA_DPS_TRANSPARENCY = 3101; // 0xc1d
        public const string WIA_DPS_TRANSPARENCY_STR = "Transparency Adapter";

        public const int WIA_DPS_TRANSPARENCY_SELECT = 3102; // 0xc1e
        public const string WIA_DPS_TRANSPARENCY_SELECT_STR = "Transparency Adapter Select";

        public const int WIA_DPS_SHOW_PREVIEW_CONTROL = 3103; // 0xc1f
        public const string WIA_DPS_SHOW_PREVIEW_CONTROL_STR = "Show preview contro";

        public const int WIA_DPS_MIN_HORIZONTAL_SHEET_FEED_SIZE = 3104; // 0xc20
        public const string WIA_DPS_MIN_HORIZONTAL_SHEET_FEED_SIZE_STR = "Minimum Horizontal Sheet Feed Size";

        public const int WIA_DPS_MIN_VERTICAL_SHEET_FEED_SIZE = 3105; // 0xc21
        public const string WIA_DPS_MIN_VERTICAL_SHEET_FEED_SIZE_STR = "Minimum Vertical Sheet Feed Size";

        public const int WIA_DPS_TRANSPARENCY_CAPABILITIES = 3106; // 0xc22
        public const string WIA_DPS_TRANSPARENCY_CAPABILITIES_STR = "Transparency Adapter Capabilities";

        public const int WIA_DPS_TRANSPARENCY_STATUS = 3107; // 0xc23
        public const string WIA_DPS_TRANSPARENCY_STATUS_STR = "Transparency Adapter Status";

        public const int WIA_DPF_MOUNT_POINT = 3330; // 0xd02
        public const string WIA_DPF_MOUNT_POINT_STR = "Directory mount point";

        public const int WIA_DPV_LAST_PICTURE_TAKEN = 3586; // 0xe02
        public const string WIA_DPV_LAST_PICTURE_TAKEN_STR = "Last Picture Taken";

        public const int WIA_DPV_IMAGES_DIRECTORY = 3587; // 0xe03
        public const string WIA_DPV_IMAGES_DIRECTORY_STR = "Images Directory";

        public const int WIA_DPV_DSHOW_DEVICE_PATH = 3588; // 0xe04
        public const string WIA_DPV_DSHOW_DEVICE_PATH_STR = "Directshow Device Path";

        public const int WIA_IPA_ITEM_NAME = 4098; // 0x1002
        public const string WIA_IPA_ITEM_NAME_STR = "Item Name";

        public const int WIA_IPA_FULL_ITEM_NAME = 4099; // 0x1003
        public const string WIA_IPA_FULL_ITEM_NAME_STR = "Full Item Name";

        public const int WIA_IPA_ITEM_TIME = 4100; // 0x1004
        public const string WIA_IPA_ITEM_TIME_STR = "Item Time Stamp";

        public const int WIA_IPA_ITEM_FLAGS = 4101; // 0x1005
        public const string WIA_IPA_ITEM_FLAGS_STR = "Item Flags";

        public const int WIA_IPA_ACCESS_RIGHTS = 4102; // 0x1006
        public const string WIA_IPA_ACCESS_RIGHTS_STR = "Access Rights";

        public const int WIA_IPA_DATATYPE = 4103; // 0x1007
        public const string WIA_IPA_DATATYPE_STR = "Data Type";

        public const int WIA_IPA_DEPTH = 4104; // 0x1008
        public const string WIA_IPA_DEPTH_STR = "Bits Per Pixe";

        public const int WIA_IPA_PREFERRED_FORMAT = 4105; // 0x1009
        public const string WIA_IPA_PREFERRED_FORMAT_STR = "Preferred Format";

        public const int WIA_IPA_FORMAT = 4106; // 0x100a
        public const string WIA_IPA_FORMAT_STR = "Format";

        public const int WIA_IPA_COMPRESSION = 4107; // 0x100b
        public const string WIA_IPA_COMPRESSION_STR = "Compression";

        public const int WIA_IPA_TYMED = 4108; // 0x100c
        public const string WIA_IPA_TYMED_STR = "Media Type";

        public const int WIA_IPA_CHANNELS_PER_PIXEL = 4109; // 0x100d
        public const string WIA_IPA_CHANNELS_PER_PIXEL_STR = "Channels Per Pixe";

        public const int WIA_IPA_BITS_PER_CHANNEL = 4110; // 0x100e
        public const string WIA_IPA_BITS_PER_CHANNEL_STR = "Bits Per Channe";

        public const int WIA_IPA_PLANAR = 4111; // 0x100f
        public const string WIA_IPA_PLANAR_STR = "Planar";

        public const int WIA_IPA_PIXELS_PER_LINE = 4112; // 0x1010
        public const string WIA_IPA_PIXELS_PER_LINE_STR = "Pixels Per Line";

        public const int WIA_IPA_BYTES_PER_LINE = 4113; // 0x1011
        public const string WIA_IPA_BYTES_PER_LINE_STR = "Bytes Per Line";

        public const int WIA_IPA_NUMBER_OF_LINES = 4114; // 0x1012
        public const string WIA_IPA_NUMBER_OF_LINES_STR = "Number of Lines";

        public const int WIA_IPA_GAMMA_CURVES = 4115; // 0x1013
        public const string WIA_IPA_GAMMA_CURVES_STR = "Gamma Curves";

        public const int WIA_IPA_ITEM_SIZE = 4116; // 0x1014
        public const string WIA_IPA_ITEM_SIZE_STR = "Item Size";

        public const int WIA_IPA_COLOR_PROFILE = 4117; // 0x1015
        public const string WIA_IPA_COLOR_PROFILE_STR = "Color Profiles";

        public const int WIA_IPA_MIN_BUFFER_SIZE = 4118; // 0x1016
        public const string WIA_IPA_MIN_BUFFER_SIZE_STR = "Buffer Size";

        public const int WIA_IPA_BUFFER_SIZE = 4118; // 0x1016
        public const string WIA_IPA_BUFFER_SIZE_STR = "Buffer Size";

        public const int WIA_IPA_REGION_TYPE = 4119; // 0x1017
        public const string WIA_IPA_REGION_TYPE_STR = "Region Type";

        public const int WIA_IPA_ICM_PROFILE_NAME = 4120; // 0x1018
        public const string WIA_IPA_ICM_PROFILE_NAME_STR = "Color Profile Name";

        public const int WIA_IPA_APP_COLOR_MAPPING = 4121; // 0x1019
        public const string WIA_IPA_APP_COLOR_MAPPING_STR = "Application Applies Color Mapping";

        public const int WIA_IPA_PROP_STREAM_COMPAT_ID = 4122; // 0x101a
        public const string WIA_IPA_PROP_STREAM_COMPAT_ID_STR = "Stream Compatibility ID";

        public const int WIA_IPA_FILENAME_EXTENSION = 4123; // 0x101b
        public const string WIA_IPA_FILENAME_EXTENSION_STR = "Filename extension";

        public const int WIA_IPA_SUPPRESS_PROPERTY_PAGE = 4124; // 0x101c
        public const string WIA_IPA_SUPPRESS_PROPERTY_PAGE_STR = "Suppress a property page";

        public const int WIA_IPC_THUMBNAIL = 5122; // 0x1402
        public const string WIA_IPC_THUMBNAIL_STR = "Thumbnail Data";

        public const int WIA_IPC_THUMB_WIDTH = 5123; // 0x1403
        public const string WIA_IPC_THUMB_WIDTH_STR = "Thumbnail Width";

        public const int WIA_IPC_THUMB_HEIGHT = 5124; // 0x1404
        public const string WIA_IPC_THUMB_HEIGHT_STR = "Thumbnail Height";

        public const int WIA_IPC_AUDIO_AVAILABLE = 5125; // 0x1405
        public const string WIA_IPC_AUDIO_AVAILABLE_STR = "Audio Available";

        public const int WIA_IPC_AUDIO_DATA_FORMAT = 5126; // 0x1406
        public const string WIA_IPC_AUDIO_DATA_FORMAT_STR = "Audio Format";

        public const int WIA_IPC_AUDIO_DATA = 5127; // 0x1407
        public const string WIA_IPC_AUDIO_DATA_STR = "Audio Data";

        public const int WIA_IPC_NUM_PICT_PER_ROW = 5128; // 0x1408
        public const string WIA_IPC_NUM_PICT_PER_ROW_STR = "Pictures per Row";

        public const int WIA_IPC_SEQUENCE = 5129; // 0x1409
        public const string WIA_IPC_SEQUENCE_STR = "Sequence Number";

        public const int WIA_IPC_TIMEDELAY = 5130; // 0x140a
        public const string WIA_IPC_TIMEDELAY_STR = "Time Delay";

        public const int WIA_IPS_CUR_INTENT = 6146; // 0x1802
        public const string WIA_IPS_CUR_INTENT_STR = "Current Intent";

        public const int WIA_IPS_XRES = 6147; // 0x1803
        public const string WIA_IPS_XRES_STR = "Horizontal Resolution";

        public const int WIA_IPS_YRES = 6148; // 0x1804
        public const string WIA_IPS_YRES_STR = "Vertical Resolution";

        public const int WIA_IPS_XPOS = 6149; // 0x1805
        public const string WIA_IPS_XPOS_STR = "Horizontal Start Position";

        public const int WIA_IPS_YPOS = 6150; // 0x1806
        public const string WIA_IPS_YPOS_STR = "Vertical Start Position";

        public const int WIA_IPS_XEXTENT = 6151; // 0x1807
        public const string WIA_IPS_XEXTENT_STR = "Horizontal Extent";

        public const int WIA_IPS_YEXTENT = 6152; // 0x1808
        public const string WIA_IPS_YEXTENT_STR = "Vertical Extent";

        public const int WIA_IPS_PHOTOMETRIC_INTERP = 6153; // 0x1809
        public const string WIA_IPS_PHOTOMETRIC_INTERP_STR = "Photometric Interpretation";

        public const int WIA_IPS_BRIGHTNESS = 6154; // 0x180a
        public const string WIA_IPS_BRIGHTNESS_STR = "Brightness";

        public const int WIA_IPS_CONTRAST = 6155; // 0x180b
        public const string WIA_IPS_CONTRAST_STR = "Contrast";

        public const int WIA_IPS_ORIENTATION = 6156; // 0x180c
        public const string WIA_IPS_ORIENTATION_STR = "Orientation";

        public const int WIA_IPS_ROTATION = 6157; // 0x180d
        public const string WIA_IPS_ROTATION_STR = "Rotation";

        public const int WIA_IPS_MIRROR = 6158; // 0x180e
        public const string WIA_IPS_MIRROR_STR = "Mirror";

        public const int WIA_IPS_THRESHOLD = 6159; // 0x180f
        public const string WIA_IPS_THRESHOLD_STR = "Threshold";

        public const int WIA_IPS_INVERT = 6160; // 0x1810
        public const string WIA_IPS_INVERT_STR = "Invert";

        public const int WIA_IPS_WARM_UP_TIME = 6161; // 0x1811
        public const string WIA_IPS_WARM_UP_TIME_STR = "Lamp Warm up Time";

        // // #if (_WIN32_WINNT >= 0x0600)

        //
        // New properties, property names and values introduced in Windows Longhorn:
        //

        public const int WIA_DPS_USER_NAME = 3112; // 0xc28
        public const string WIA_DPS_USER_NAME_STR = "User Name";

        public const int WIA_DPS_SERVICE_ID = 3113; // 0xc29
        public const string WIA_DPS_SERVICE_ID_STR = "Service ID";

        public const int WIA_DPS_DEVICE_ID = 3114; // 0xc2a
        public const string WIA_DPS_DEVICE_ID_STR = "Device ID";

        public const int WIA_DPS_GLOBAL_IDENTITY = 3115; // 0xc2b
        public const string WIA_DPS_GLOBAL_IDENTITY_STR = "Global Identity";

        public const int WIA_IPS_DESKEW_X = 6162; // 0x1812
        public const string WIA_IPS_DESKEW_X_STR = "DeskewX";

        public const int WIA_IPS_DESKEW_Y = 6163; // 0x1813
        public const string WIA_IPS_DESKEW_Y_STR = "DeskewY";

        public const int WIA_IPS_SEGMENTATION = 6164; // 0x1814
        public const string WIA_IPS_SEGMENTATION_STR = "Segmentation";

        public const string WIA_SEGMENTATION_FILTER_STR = "SegmentationFilter";
        public const string WIA_IMAGEPROC_FILTER_STR = "ImageProcessingFilter";

        public const int WIA_IPS_MAX_HORIZONTAL_SIZE = 6165; // 0x1815
        public const string WIA_IPS_MAX_HORIZONTAL_SIZE_STR = "Maximum Horizontal Scan Size";

        public const int WIA_IPS_MAX_VERTICAL_SIZE = 6166; // 0x1816
        public const string WIA_IPS_MAX_VERTICAL_SIZE_STR = "Maximum Vertical Scan Size";

        public const int WIA_IPS_MIN_HORIZONTAL_SIZE = 6167; // 0x1817
        public const string WIA_IPS_MIN_HORIZONTAL_SIZE_STR = "Minimum Horizontal Scan Size";

        public const int WIA_IPS_MIN_VERTICAL_SIZE = 6168; // 0x1818
        public const string WIA_IPS_MIN_VERTICAL_SIZE_STR = "Minimum Vertical Scan Size";

        public const int WIA_IPS_TRANSFER_CAPABILITIES = 6169; // 0x1819
        public const string WIA_IPS_TRANSFER_CAPABILITIES_STR = "Transfer Capabilities";

        public const int WIA_IPS_SHEET_FEEDER_REGISTRATION = 3078; // 0xc06
        public const string WIA_IPS_SHEET_FEEDER_REGISTRATION_STR = "Sheet Feeder Registration";

        public const int WIA_IPS_DOCUMENT_HANDLING_SELECT = 3088; // 0xc10
        public const string WIA_IPS_DOCUMENT_HANDLING_SELECT_STR = "Document Handling Select";

        public const int WIA_IPS_OPTICAL_XRES = 3090; // 0xc12
        public const string WIA_IPS_OPTICAL_XRES_STR = "Horizontal Optical Resolution";

        public const int WIA_IPS_OPTICAL_YRES = 3091; // 0xc13
        public const string WIA_IPS_OPTICAL_YRES_STR = "Vertical Optical Resolution";

        public const int WIA_IPS_PAGES = 3096; // 0xc18
        public const string WIA_IPS_PAGES_STR = "Pages";

        public const int WIA_IPS_PAGE_SIZE = 3097; // 0xc19
        public const string WIA_IPS_PAGE_SIZE_STR = "Page Size";

        public const int WIA_IPS_PAGE_WIDTH = 3098; // 0xc1a
        public const string WIA_IPS_PAGE_WIDTH_STR = "Page Width";

        public const int WIA_IPS_PAGE_HEIGHT = 3099; // 0xc1b
        public const string WIA_IPS_PAGE_HEIGHT_STR = "Page Height";

        public const int WIA_IPS_PREVIEW = 3100; // 0xc1c
        public const string WIA_IPS_PREVIEW_STR = "Preview";

        public const int WIA_IPS_SHOW_PREVIEW_CONTROL = 3103; // 0xc1f
        public const string WIA_IPS_SHOW_PREVIEW_CONTROL_STR = "Show preview contro";

        public const int WIA_IPS_FILM_SCAN_MODE = 3104; // 0xc20
        public const string WIA_IPS_FILM_SCAN_MODE_STR = "Film Scan Mode";

        public const int WIA_IPS_LAMP = 3105; // 0xc21
        public const string WIA_IPS_LAMP_STR = "Lamp";

        public const int WIA_IPS_LAMP_AUTO_OFF = 3106; // 0xc22
        public const string WIA_IPS_LAMP_AUTO_OFF_STR = "Lamp Auto Off";

        public const int WIA_IPS_AUTO_DESKEW = 3107; // 0xc23
        public const string WIA_IPS_AUTO_DESKEW_STR = "Automatic Deskew";

        public const int WIA_IPS_SUPPORTS_CHILD_ITEM_CREATION = 3108; // 0xc24
        public const string WIA_IPS_SUPPORTS_CHILD_ITEM_CREATION_STR = "Supports Child Item Creation";

        public const int WIA_IPS_XSCALING = 3109; // 0xc25
        public const string WIA_IPS_XSCALING_STR = "Horizontal Scaling";

        public const int WIA_IPS_YSCALING = 3110; // 0xc26
        public const string WIA_IPS_YSCALING_STR = "Vertical Scaling";

        public const int WIA_IPS_PREVIEW_TYPE = 3111; // 0xc27
        public const string WIA_IPS_PREVIEW_TYPE_STR = "Preview Type";

        public const int WIA_IPA_ITEM_CATEGORY = 4125; // 0x101d
        public const string WIA_IPA_ITEM_CATEGORY_STR = "Item Category";

        public const int WIA_IPA_UPLOAD_ITEM_SIZE = 4126; // 0x101e
        public const string WIA_IPA_UPLOAD_ITEM_SIZE_STR = "Upload Item Size";

        public const int WIA_IPA_ITEMS_STORED = 4127; // 0x101f
        public const string WIA_IPA_ITEMS_STORED_STR = "Items Stored";

        public const int WIA_IPA_RAW_BITS_PER_CHANNEL = 4128; // 0x1020
        public const string WIA_IPA_RAW_BITS_PER_CHANNEL_STR = "Raw Bits Per Channe";

        public const int WIA_IPS_FILM_NODE_NAME = 4129; // 0x1021
        public const string WIA_IPS_FILM_NODE_NAME_STR = "Film Node Name";

        //
        // WIA_IPA_ITEM_CATEGORY constants
        //
        // DEFINE_GUID(WIA_CATEGORY_FINISHED_FILE,0xff2b77ca, 0xcf84, 0x432b, 0xa7, 0x35, 0x3a, 0x13, 0x0d, 0xde, 0x2a, 0x88);
        // DEFINE_GUID(WIA_CATEGORY_FLATBED,      0xfb607b1f, 0x43f3, 0x488b, 0x85, 0x5b, 0xfb, 0x70, 0x3e, 0xc3, 0x42, 0xa6);
        // DEFINE_GUID(WIA_CATEGORY_FEEDER,       0xfe131934, 0xf84c, 0x42ad, 0x8d, 0xa4, 0x61, 0x29, 0xcd, 0xdd, 0x72, 0x88);
        // DEFINE_GUID(WIA_CATEGORY_FILM,         0xfcf65be7, 0x3ce3, 0x4473, 0xaf, 0x85, 0xf5, 0xd3, 0x7d, 0x21, 0xb6, 0x8a);
        // DEFINE_GUID(WIA_CATEGORY_ROOT,         0xf193526f, 0x59b8, 0x4a26, 0x98, 0x88, 0xe1, 0x6e, 0x4f, 0x97, 0xce, 0x10);
        // DEFINE_GUID(WIA_CATEGORY_FOLDER,       0xc692a446, 0x6f5a, 0x481d, 0x85, 0xbb, 0x92, 0xe2, 0xe8, 0x6f, 0xd3, 0xa);
        // DEFINE_GUID(WIA_CATEGORY_FEEDER_FRONT, 0x4823175c, 0x3b28, 0x487b, 0xa7, 0xe6, 0xee, 0xbc, 0x17, 0x61, 0x4f, 0xd1);
        // DEFINE_GUID(WIA_CATEGORY_FEEDER_BACK,  0x61ca74d4, 0x39db, 0x42aa, 0x89, 0xb1, 0x8c, 0x19, 0xc9, 0xcd, 0x4c, 0x23);

        //
        // GUID for Default Segmentation Filter
        //
        // DEFINE_GUID(CLSID_WiaDefaultSegFilter, 0xD4F4D30B, 0x0B29, 0x4508, 0x89, 0x22, 0x0C, 0x57, 0x97, 0xD4, 0x27, 0x65);

        //
        // WIA_IPS_TRANSFER_CAPABILITIES flags:
        //
        public const int WIA_TRANSFER_CHILDREN_SINGLE_SCAN = 0x00000001;

        //
        // WIA_IPS_SEGMENTATION_FILTER constants
        //
        public const int WIA_USE_SEGMENTATION_FILTER = 0;
        public const int WIA_DONT_USE_SEGMENTATION_FILTER = 1;

        //
        // WIA_IPS_FILM_SCAN_MODE constants
        //
        public const int WIA_FILM_COLOR_SLIDE = 0;
        public const int WIA_FILM_COLOR_NEGATIVE = 1;
        public const int WIA_FILM_BW_NEGATIVE = 2;

        //
        // WIA_IPS_LAMP constants
        //
        public const int WIA_LAMP_ON = 0;
        public const int WIA_LAMP_OFF = 1;

        //
        // WIA_IPS_AUTO_DESKEW constants:
        //
        public const int WIA_AUTO_DESKEW_ON = 0;
        public const int WIA_AUTO_DESKEW_OFF = 1;

        //
        // WIA_IPS_PREVIEW_TYPE constants:
        //
        public const int WIA_ADVANCED_PREVIEW = 0;
        public const int WIA_BASIC_PREVIEW = 1;

        //
        // WIA Raw Format header: 
        //
        // typedef struct _WIA_RAW_HEADER
        // {
        //     DWORD Tag; 
        //     DWORD Version;
        //     DWORD HeaderSize; 
        //     DWORD XRes; 
        //     DWORD YRes;                         
        //     DWORD XExtent;
        //     DWORD YExtent; 
        //     DWORD BytesPerLine;
        //     DWORD BitsPerPixel;
        //     DWORD ChannelsPerPixel;
        //     DWORD DataType;    
        //     BYTE  BitsPerChannel[8]; 
        //     DWORD Compression; 
        //     DWORD PhotometricInterp; 
        //     DWORD LineOrder; 
        //     DWORD RawDataOffset;
        //     DWORD RawDataSize; 
        //     DWORD PaletteOffset;
        //     DWORD PaletteSize; 
        // } WIA_RAW_HEADER;

        // typedef struct _WIA_RAW_HEADER *PWIA_RAW_HEADER;

        //// #endif //// #if (_WIN32_WINNT >= 0x0600)

        //
        // Use the WIA property offsets to define private WIA properties.
        //
        // Example: (Creating a private WIA property)
        //
        // public const int WIA_THE_PROP         (WIA_PRIVATE_DEVPROP + 1000)
        // public const string WIA_THE_PROP_STR     "The Property")
        //

        //
        // Private property offset constants
        //

        public const int WIA_PRIVATE_DEVPROP = 38914;  // offset for private device (root) item properties
        public const int WIA_PRIVATE_ITEMPROP = 71682;  // offset for private item properties

        //
        // WIA image format constants
        //

        // DEFINE_GUID(WiaImgFmt_UNDEFINED,0xb96b3ca9,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_RAWRGB,   0xbca48b55,0xf272,0x4371,0xb0,0xf1,0x4a,0x15,0x0d,0x05,0x7b,0xb4);
        // DEFINE_GUID(WiaImgFmt_MEMORYBMP,0xb96b3caa,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_BMP,      0xb96b3cab,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_EMF,      0xb96b3cac,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_WMF,      0xb96b3cad,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_JPEG,     0xb96b3cae,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_PNG,      0xb96b3caf,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_GIF,      0xb96b3cb0,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_TIFF,     0xb96b3cb1,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_EXIF,     0xb96b3cb2,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_PHOTOCD,  0xb96b3cb3,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_FLASHPIX, 0xb96b3cb4,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_ICO,      0xb96b3cb5,0x0728,0x11d3,0x9d,0x7b,0x00,0x00,0xf8,0x1e,0xf3,0x2e);
        // DEFINE_GUID(WiaImgFmt_CIFF,     0x9821a8ab,0x3a7e,0x4215,0x94,0xe0,0xd2,0x7a,0x46,0x0c,0x03,0xb2);
        // DEFINE_GUID(WiaImgFmt_PICT,     0xa6bc85d8,0x6b3e,0x40ee,0xa9,0x5c,0x25,0xd4,0x82,0xe4,0x1a,0xdc);
        // DEFINE_GUID(WiaImgFmt_JPEG2K,   0x344ee2b2,0x39db,0x4dde,0x81,0x73,0xc4,0xb7,0x5f,0x8f,0x1e,0x49);
        // DEFINE_GUID(WiaImgFmt_JPEG2KX,  0x43e14614,0xc80a,0x4850,0xba,0xf3,0x4b,0x15,0x2d,0xc8,0xda,0x27);
        //// #if (_WIN32_WINNT >= 0x0600)
        // DEFINE_GUID(WiaImgFmt_RAW,      0x6f120719,0xf1a8,0x4e07,0x9a,0xde,0x9b,0x64,0xc6,0x3a,0x3d,0xcc);
        // DEFINE_GUID(WiaImgFmt_JBIG,     0x41e8dd92,0x2f0a,0x43d4,0x86,0x36,0xf1,0x61,0x4b,0xa1,0x1e,0x46);
        //// #endif //// #if (_WIN32_WINNT >= 0x0600)


        //
        // WIA document format constants
        //

        // DEFINE_GUID(WiaImgFmt_RTF,      0x573dd6a3,0x4834,0x432d,0xa9,0xb5,0xe1,0x98,0xdd,0x9e,0x89,0x0d);
        // DEFINE_GUID(WiaImgFmt_XML,      0xb9171457,0xdac8,0x4884,0xb3,0x93,0x15,0xb4,0x71,0xd5,0xf0,0x7e);
        // DEFINE_GUID(WiaImgFmt_HTML,     0xc99a4e62,0x99de,0x4a94,0xac,0xca,0x71,0x95,0x6a,0xc2,0x97,0x7d);
        // DEFINE_GUID(WiaImgFmt_TXT,      0xfafd4d82,0x723f,0x421f,0x93,0x18,0x30,0x50,0x1a,0xc4,0x4b,0x59);
        //// #if (_WIN32_WINNT >= 0x0600)
        // DEFINE_GUID(WiaImgFmt_PDFA,     0x9980bd5b,0x3463,0x43c7,0xbd,0xca,0x3c,0xaa,0x14,0x6f,0x22,0x9f);
        // DEFINE_GUID(WiaImgFmt_XPS,      0x700b4a0f,0x2011,0x411c,0xb4,0x30,0xd1,0xe0,0xb2,0xe1,0x0b,0x28);
        //// #endif //// #if (_WIN32_WINNT >= 0x0600)

        //
        // WIA video format constants
        //

        // DEFINE_GUID(WiaImgFmt_MPG,      0xecd757e4,0xd2ec,0x4f57,0x95,0x5d,0xbc,0xf8,0xa9,0x7c,0x4e,0x52);
        // DEFINE_GUID(WiaImgFmt_AVI,      0x32f8ca14,0x087c,0x4908,0xb7,0xc4,0x67,0x57,0xfe,0x7e,0x90,0xab);

        //
        // WIA audio format constants
        //

        // DEFINE_GUID(WiaAudFmt_WAV,      0xf818e146,0x07af,0x40ff,0xae,0x55,0xbe,0x8f,0x2c,0x06,0x5d,0xbe);
        // DEFINE_GUID(WiaAudFmt_MP3,      0x0fbc71fb,0x43bf,0x49f2,0x91,0x90,0xe6,0xfe,0xcf,0xf3,0x7e,0x54);
        // DEFINE_GUID(WiaAudFmt_AIFF,     0x66e2bf4f,0xb6fc,0x443f,0x94,0xc8,0x2f,0x33,0xc8,0xa6,0x5a,0xaf);
        // DEFINE_GUID(WiaAudFmt_WMA,      0xd61d6413,0x8bc2,0x438f,0x93,0xad,0x21,0xbd,0x48,0x4d,0xb6,0xa1);

        //
        // WIA misc format constants
        //

        // DEFINE_GUID(WiaImgFmt_ASF,      0x8d948ee9,0xd0aa,0x4a12,0x9d,0x9a,0x9c,0xc5,0xde,0x36,0x19,0x9b);
        // DEFINE_GUID(WiaImgFmt_SCRIPT,   0xfe7d6c53,0x2dac,0x446a,0xb0,0xbd,0xd7,0x3e,0x21,0xe9,0x24,0xc9);
        // DEFINE_GUID(WiaImgFmt_EXEC,     0x485da097,0x141e,0x4aa5,0xbb,0x3b,0xa5,0x61,0x8d,0x95,0xd0,0x2b);
        // DEFINE_GUID(WiaImgFmt_UNICODE16,0x1b7639b6,0x6357,0x47d1,0x9a,0x07,0x12,0x45,0x2d,0xc0,0x73,0xe9);
        // DEFINE_GUID(WiaImgFmt_DPOF,     0x369eeeab,0xa0e8,0x45ca,0x86,0xa6,0xa8,0x3c,0xe5,0x69,0x7e,0x28);

        //
        // WIA event constants
        //

        // DEFINE_GUID(WIA_EVENT_DEVICE_DISCONNECTED,0x143e4e83,0x6497,0x11d2,0xa2,0x31,0x00,0xc0,0x4f,0xa3,0x18,0x09);
        // DEFINE_GUID(WIA_EVENT_DEVICE_CONNECTED,   0xa28bbade,0x64b6,0x11d2,0xa2,0x31,0x00,0xc0,0x4f,0xa3,0x18,0x09);
        // DEFINE_GUID(WIA_EVENT_ITEM_DELETED,       0x1d22a559,0xe14f,0x11d2,0xb3,0x26,0x00,0xc0,0x4f,0x68,0xce,0x61);
        // DEFINE_GUID(WIA_EVENT_ITEM_CREATED,       0x4c8f4ef5,0xe14f,0x11d2,0xb3,0x26,0x00,0xc0,0x4f,0x68,0xce,0x61);
        // DEFINE_GUID(WIA_EVENT_TREE_UPDATED,       0xc9859b91,0x4ab2,0x4cd6,0xa1,0xfc,0x58,0x2e,0xec,0x55,0xe5,0x85);
        // DEFINE_GUID(WIA_EVENT_VOLUME_INSERT,      0x9638bbfd,0xd1bd,0x11d2,0xb3,0x1f,0x00,0xc0,0x4f,0x68,0xce,0x61);
        // DEFINE_GUID(WIA_EVENT_SCAN_IMAGE,         0xa6c5a715,0x8c6e,0x11d2,0x97,0x7a,0x00,0x00,0xf8,0x7a,0x92,0x6f);
        // DEFINE_GUID(WIA_EVENT_SCAN_PRINT_IMAGE,   0xb441f425,0x8c6e,0x11d2,0x97,0x7a,0x00,0x00,0xf8,0x7a,0x92,0x6f);
        // DEFINE_GUID(WIA_EVENT_SCAN_FAX_IMAGE,     0xc00eb793,0x8c6e,0x11d2,0x97,0x7a,0x00,0x00,0xf8,0x7a,0x92,0x6f);
        // DEFINE_GUID(WIA_EVENT_SCAN_OCR_IMAGE,     0x9d095b89,0x37d6,0x4877,0xaf,0xed,0x62,0xa2,0x97,0xdc,0x6d,0xbe);
        // DEFINE_GUID(WIA_EVENT_SCAN_EMAIL_IMAGE,   0xc686dcee,0x54f2,0x419e,0x9a,0x27,0x2f,0xc7,0xf2,0xe9,0x8f,0x9e);
        // DEFINE_GUID(WIA_EVENT_SCAN_FILM_IMAGE,    0x9b2b662c,0x6185,0x438c,0xb6,0x8b,0xe3,0x9e,0xe2,0x5e,0x71,0xcb);
        // DEFINE_GUID(WIA_EVENT_SCAN_IMAGE2,        0xfc4767c1,0xc8b3,0x48a2,0x9c,0xfa,0x2e,0x90,0xcb,0x3d,0x35,0x90);
        // DEFINE_GUID(WIA_EVENT_SCAN_IMAGE3,        0x154e27be,0xb617,0x4653,0xac,0xc5,0x0f,0xd7,0xbd,0x4c,0x65,0xce);
        // DEFINE_GUID(WIA_EVENT_SCAN_IMAGE4,        0xa65b704a,0x7f3c,0x4447,0xa7,0x5d,0x8a,0x26,0xdf,0xca,0x1f,0xdf);
        // DEFINE_GUID(WIA_EVENT_STORAGE_CREATED,    0x353308b2,0xfe73,0x46c8,0x89,0x5e,0xfa,0x45,0x51,0xcc,0xc8,0x5a);
        // DEFINE_GUID(WIA_EVENT_STORAGE_DELETED,    0x5e41e75e,0x9390,0x44c5,0x9a,0x51,0xe4,0x70,0x19,0xe3,0x90,0xcf);
        // DEFINE_GUID(WIA_EVENT_STI_PROXY,          0xd711f81f,0x1f0d,0x422d,0x86,0x41,0x92,0x7d,0x1b,0x93,0xe5,0xe5);
        // DEFINE_GUID(WIA_EVENT_CANCEL_IO,          0xc860f7b8,0x9ccd,0x41ea,0xbb,0xbf,0x4d,0xd0,0x9c,0x5b,0x17,0x95);

        //
        // Power management event GUIDs, sent by the WIA service to drivers
        //

        // DEFINE_GUID(WIA_EVENT_POWER_SUSPEND,      0xa0922ff9,0xc3b4,0x411c,0x9e,0x29,0x03,0xa6,0x69,0x93,0xd2,0xbe);
        // DEFINE_GUID(WIA_EVENT_POWER_RESUME,       0x618f153e,0xf686,0x4350,0x96,0x34,0x41,0x15,0xa3,0x04,0x83,0x0c);

        //
        // No action handler and prompt handler
        //

        // DEFINE_GUID(WIA_EVENT_HANDLER_NO_ACTION,  0xe0372b7d,0xe115,0x4525,0xbc,0x55,0xb6,0x29,0xe6,0x8c,0x74,0x5a);
        // DEFINE_GUID(WIA_EVENT_HANDLER_PROMPT,     0x5f4baad0,0x4d59,0x4fcd,0xb2,0x13,0x78,0x3c,0xe7,0xa9,0x2f,0x22);

        //
        // WIA command constants
        //

        // DEFINE_GUID(WIA_CMD_SYNCHRONIZE,          0x9b26b7b2,0xacad,0x11d2,0xa0,0x93,0x00,0xc0,0x4f,0x72,0xdc,0x3c);
        // DEFINE_GUID(WIA_CMD_TAKE_PICTURE,         0xaf933cac,0xacad,0x11d2,0xa0,0x93,0x00,0xc0,0x4f,0x72,0xdc,0x3c);
        // DEFINE_GUID(WIA_CMD_DELETE_ALL_ITEMS,     0xe208c170,0xacad,0x11d2,0xa0,0x93,0x00,0xc0,0x4f,0x72,0xdc,0x3c);
        // DEFINE_GUID(WIA_CMD_CHANGE_DOCUMENT,      0x04e725b0,0xacae,0x11d2,0xa0,0x93,0x00,0xc0,0x4f,0x72,0xdc,0x3c);
        // DEFINE_GUID(WIA_CMD_UNLOAD_DOCUMENT,      0x1f3b3d8e,0xacae,0x11d2,0xa0,0x93,0x00,0xc0,0x4f,0x72,0xdc,0x3c);
        // DEFINE_GUID(WIA_CMD_DIAGNOSTIC,           0x10ff52f5,0xde04,0x4cf0,0xa5,0xad,0x69,0x1f,0x8d,0xce,0x01,0x41);
        // DEFINE_GUID(WIA_CMD_FORMAT,               0xc3a693aa,0xf788,0x4d34,0xa5,0xb0,0xbe,0x71,0x90,0x75,0x9a,0x24);

        //
        // WIA command constants used for debugging only
        //

        // DEFINE_GUID(WIA_CMD_DELETE_DEVICE_TREE,   0x73815942,0xdbea,0x11d2,0x84,0x16,0x00,0xc0,0x4f,0xa3,0x61,0x45);
        // DEFINE_GUID(WIA_CMD_BUILD_DEVICE_TREE,    0x9cba5ce0,0xdbea,0x11d2,0x84,0x16,0x00,0xc0,0x4f,0xa3,0x61,0x45);

        public const uint FACILITY_WIA = 33;
        public const uint BASE_VAL_WIA_ERROR = 0x00000000;
        public const uint BASE_VAL_WIA_SUCCESS = 0x00000000;

        public const uint WIA_ERROR_GENERAL_ERROR = 0x80210001;
        public const uint WIA_ERROR_PAPER_JAM = 0x80210002;
        public const uint WIA_ERROR_PAPER_EMPTY = 0x80210003;
        public const uint WIA_ERROR_PAPER_PROBLEM = 0x80210004;
        public const uint WIA_ERROR_OFFLINE = 0x80210005;
        public const uint WIA_ERROR_BUSY = 0x80210006;
        public const uint WIA_ERROR_WARMING_UP = 0x80210007;
        public const uint WIA_ERROR_USER_INTERVENTION = 0x80210008;
        public const uint WIA_ERROR_ITEM_DELETED = 0x80210009;
        public const uint WIA_ERROR_DEVICE_COMMUNICATION = 0x8021000A;
        public const uint WIA_ERROR_INVALID_COMMAND = 0x8021000B;
        public const uint WIA_ERROR_INCORRECT_HARDWARE_SETTING = 0x8021000C;
        public const uint WIA_ERROR_DEVICE_LOCKED = 0x8021000D;
        public const uint WIA_ERROR_EXCEPTION_IN_DRIVER = 0x8021000E;
        public const uint WIA_ERROR_INVALID_DRIVER_RESPONSE = 0x8021000F;
        public const uint WIA_ERROR_COVER_OPEN = 0x80210010;
        public const uint WIA_ERROR_LAMP_OFF = 0x80210011;
        public const uint WIA_ERROR_DESTINATION = 0x80210012;
        public const uint WIA_ERROR_NETWORK_RESERVATION_FAILED = 0x80210013;
        public const uint WIA_STATUS_END_OF_MEDIA = 0x210001;

        //
        // Definitions for errors and status codes passed to IWiaDataTransfer::BandedDataCallback as the lReason parameter.
        // These codes are in addition to the errors defined above; in some cases the SEVERITY_SUCCESS version of
        // an error is meant to replace the SEVERITY_ERROR version listed above.
        //

        public const uint WIA_STATUS_WARMING_UP = 0x210002;
        public const uint WIA_STATUS_CALIBRATING = 0x210003;
        public const uint WIA_STATUS_RESERVING_NETWORK_DEVICE = 0x210006;
        public const uint WIA_STATUS_NETWORK_DEVICE_RESERVED = 0x210007;
        public const uint WIA_STATUS_CLEAR = 0x210008;
        public const uint WIA_STATUS_SKIP_ITEM = 0x210009;
        public const uint WIA_STATUS_NOT_HANDLED = 0x21000A; 

        //
        // The value is returned by Scansetting.dll when the user chooses to change the scanner in scandialog
        //

        public const uint WIA_S_CHANGE_DEVICE = 0x21000B; 

        //
        // SelectDeviceDlg and SelectDeviceDlgID status code when there are no devices available
        //

        public const uint WIA_S_NO_DEVICE_AVAILABLE = 0x80210015; 

        //
        // SelectDeviceDlg and GetImageDlg flag constants
        //

        public const uint WIA_SELECT_DEVICE_NODEFAULT = 0x00000001;

        //
        // DeviceDlg and GetImageDlg flags constants
        //

        public const uint WIA_DEVICE_DIALOG_SINGLE_IMAGE = 0x00000002;   // Only allow one image to be selected
        public const uint WIA_DEVICE_DIALOG_USE_COMMON_UI = 0x00000004;   // Give preference to the system-provided UI, if available

        //
        // RegisterEventCallbackInterface and RegisterEventCallbackCLSID flag constants
        //

        public const uint WIA_REGISTER_EVENT_CALLBACK = 0x00000001;
        public const uint WIA_UNREGISTER_EVENT_CALLBACK = 0x00000002;
        public const uint WIA_SET_DEFAULT_HANDLER = 0x00000004;

        //
        // WIA event type constants
        //

        public const uint WIA_NOTIFICATION_EVENT = 0x00000001;
        public const uint WIA_ACTION_EVENT = 0x00000002;

        //
        // Additional WIA raw format constants
        //

        public const uint WIA_LINE_ORDER_TOP_TO_BOTTOM = 0x00000001;
        public const uint WIA_LINE_ORDER_BOTTOM_TO_TOP = 0x00000002;

        //
        // WIA event persistent handler flag constants
        //

        public const uint WIA_IS_DEFAULT_HANDLER = 0x00000001;

        //
        // WIA connected and disconnected event description strings
        //

        public const string WIA_EVENT_DEVICE_DISCONNECTED_STR = "Device Disconnected";
        public const string WIA_EVENT_DEVICE_CONNECTED_STR = "Device Connected";

        //
        // WIA event and command icon resource identifier constants
        //
        // Events   : -1000 to -1499 (Standard), -1500 to -1999 (Custom)
        // Commands : -2000 to -2499 (Standard), -2500 to -2999 (Custom)
        //

        // FIXME: import sti.dll properly
        //public const int WIA_ICON_DEVICE_DISCONNECTED ("sti.dll,-1001")
        //public const int WIA_ICON_DEVICE_CONNECTED    ("sti.dll,-1001")
        //public const int WIA_ICON_ITEM_DELETED        ("sti.dll,-1001")
        //public const int WIA_ICON_ITEM_CREATED        ("sti.dll,-1001")
        //public const int WIA_ICON_TREE_UPDATED        ("sti.dll,-1001")
        //public const int WIA_ICON_VOLUME_INSERT       ("sti.dll,-1001")
        //public const int WIA_ICON_SCAN_BUTTON_PRESS   ("sti.dll,-1001")
        //public const int WIA_ICON_SYNCHRONIZE         ("sti.dll,-2000")
        //public const int WIA_ICON_TAKE_PICTURE        ("sti.dll,-2001")
        //public const int WIA_ICON_DELETE_ALL_ITEMS    ("sti.dll,-2002")
        //public const int WIA_ICON_CHANGE_DOCUMENT     ("sti.dll,-2003")
        //public const int WIA_ICON_UNLOAD_DOCUMENT     ("sti.dll,-2004")
        //public const int WIA_ICON_DELETE_DEVICE_TREE  ("sti.dll,-2005")
        //public const int WIA_ICON_BUILD_DEVICE_TREE   ("sti.dll,-2006")

        //
        // WIA TYMED constants
        //

        public const int TYMED_CALLBACK = 128;
        public const int TYMED_MULTIPAGE_FILE = 256;
        public const int TYMED_MULTIPAGE_CALLBACK = 512;

        //
        // IWiaDataCallback and IWiaMiniDrvCallBack message ID constants
        //

        public const int IT_MSG_DATA_HEADER = 0x0001;
        public const int IT_MSG_DATA = 0x0002;
        public const int IT_MSG_STATUS = 0x0003;
        public const int IT_MSG_TERMINATION = 0x0004;
        public const int IT_MSG_NEW_PAGE = 0x0005;
        public const int IT_MSG_FILE_PREVIEW_DATA = 0x0006;
        public const int IT_MSG_FILE_PREVIEW_DATA_HEADER = 0x0007;

        //
        // IWiaDataCallback and IWiaMiniDrvCallBack status flag constants
        //

        public const int IT_STATUS_TRANSFER_FROM_DEVICE = 0x0001;
        public const int IT_STATUS_PROCESSING_DATA = 0x0002;
        public const int IT_STATUS_TRANSFER_TO_CLIENT = 0x0004;
        public const int IT_STATUS_MASK = 0x0007;  // any status value that doesn't
        // fit the mask is an HRESULT
        //
        // IWiaTransfer flags
        //

        public const int WIA_TRANSFER_ACQUIRE_CHILDREN = 0x0001;

        //
        // IWiaTransferCallback Message types
        //

        public const int WIA_TRANSFER_MSG_STATUS = 0x00001;
        public const int WIA_TRANSFER_MSG_END_OF_STREAM = 0x00002;
        public const int WIA_TRANSFER_MSG_END_OF_TRANSFER = 0x00003;
        public const int WIA_TRANSFER_MSG_DEVICE_STATUS = 0x00005;
        public const int WIA_TRANSFER_MSG_NEW_PAGE = 0x00006;

        //
        // IWiaEventCallback code constants
        //

        public const int WIA_MAJOR_EVENT_DEVICE_CONNECT = 0x01;
        public const int WIA_MAJOR_EVENT_DEVICE_DISCONNECT = 0x02;
        public const int WIA_MAJOR_EVENT_PICTURE_TAKEN = 0x03;
        public const int WIA_MAJOR_EVENT_PICTURE_DELETED = 0x04;

        //
        // WIA device connection status constants
        //

        public const int WIA_DEVICE_NOT_CONNECTED = 0;
        public const int WIA_DEVICE_CONNECTED = 1;

        //
        // EnumDeviceCapabilities and drvGetCapabilities flags
        //

        public const int WIA_DEVICE_COMMANDS = 1;
        public const int WIA_DEVICE_EVENTS = 2;

        //
        // EnumDeviceInfo Flags
        //

        public const int WIA_DEVINFO_ENUM_ALL = 0x0000000F;
        public const int WIA_DEVINFO_ENUM_LOCAL = 0x00000010;


        //
        // WIA item type constants
        //

        public const int WiaItemTypeFree = 0x00000000;
        public const int WiaItemTypeImage = 0x00000001;
        public const int WiaItemTypeFile = 0x00000002;
        public const int WiaItemTypeFolder = 0x00000004;
        public const int WiaItemTypeRoot = 0x00000008;
        public const int WiaItemTypeAnalyze = 0x00000010;
        public const int WiaItemTypeAudio = 0x00000020;
        public const int WiaItemTypeDevice = 0x00000040;
        public const int WiaItemTypeDeleted = 0x00000080;
        public const int WiaItemTypeDisconnected = 0x00000100;
        public const int WiaItemTypeHPanorama = 0x00000200;
        public const int WiaItemTypeVPanorama = 0x00000400;
        public const int WiaItemTypeBurst = 0x00000800;
        public const int WiaItemTypeStorage = 0x00001000;
        public const int WiaItemTypeTransfer = 0x00002000;
        public const int WiaItemTypeGenerated = 0x00004000;
        public const int WiaItemTypeHasAttachments = 0x00008000;
        public const int WiaItemTypeVideo = 0x00010000;
        public const uint WiaItemTypeRemoved = 0x80000000;
        //
        // 0x00020000 has been reserved for the TWAIN compatiblity layer
        // pass-through feature.
        //
        // // #if (_WIN32_WINNT >= 0x0600)
        public const int WiaItemTypeDocument = 0x00040000;
        public const int WiaItemTypeProgrammableDataSource = 0x00080000;
        public const uint WiaItemTypeMask = 0x800FFFFF;
        //#else
        // public const uint WiaItemTypeMask = 0x8003FFFF;
        // // #endif

        //
        // Big max device specific item context
        //

        public const int WIA_MAX_CTX_SIZE = 0x01000000;

        //
        // WIA property access flag constants
        //

        public const int WIA_PROP_READ = 0x01;
        public const int WIA_PROP_WRITE = 0x02;
        public const int WIA_PROP_RW = (WIA_PROP_READ | WIA_PROP_WRITE);
        public const int WIA_PROP_SYNC_REQUIRED = 0x04;

        public const int WIA_PROP_NONE = 0x08;
        public const int WIA_PROP_RANGE = 0x10;
        public const int WIA_PROP_LIST = 0x20;
        public const int WIA_PROP_FLAG = 0x40;

        public const int WIA_PROP_CACHEABLE = 0x10000;

        //
        // IWiaItem2 CreateChildItem flag constants
        //

        public const int COPY_PARENT_PROPERTY_VALUES = 0x40000000;

        //
        // WIA item access flag constants
        //

        public const int WIA_ITEM_CAN_BE_DELETED = 0x80;
        public const int WIA_ITEM_READ = WIA_PROP_READ;
        public const int WIA_ITEM_WRITE = WIA_PROP_WRITE;
        public const int WIA_ITEM_RD = (WIA_ITEM_READ | WIA_ITEM_CAN_BE_DELETED);
        public const int WIA_ITEM_RWD = (WIA_ITEM_READ | WIA_ITEM_WRITE | WIA_ITEM_CAN_BE_DELETED);

        //
        // WIA property container constants
        //

        public const int WIA_RANGE_MIN = 0;
        public const int WIA_RANGE_NOM = 1;
        public const int WIA_RANGE_MAX = 2;
        public const int WIA_RANGE_STEP = 3;
        public const int WIA_RANGE_NUM_ELEMS = 4;

        public const int WIA_LIST_COUNT = 0;
        public const int WIA_LIST_NOM = 1;
        public const int WIA_LIST_VALUES = 2;
        public const int WIA_LIST_NUM_ELEMS = 2;

        public const int WIA_FLAG_NOM = 0;
        public const int WIA_FLAG_VALUES = 1;
        public const int WIA_FLAG_NUM_ELEMS = 2;

        //
        // WIA property LIST container MACROS
        //

        // public const int WIA_PROP_LIST_COUNT(ppv) (((PROPVARIANT*)ppv)->cal.cElems - WIA_LIST_VALUES)

        // public const int WIA_PROP_LIST_VALUE(ppv, index)                               
        //      ((index > ((PROPVARIANT*) ppv)->cal.cElems - WIA_LIST_VALUES) || (index < -WIA_LIST_NOM)) ? 
        //      NULL :                                                           
        //      (((PROPVARIANT*) ppv)->vt == VT_UI1) ?                           
        //      ((PROPVARIANT*) ppv)->caub.pElems[WIA_LIST_VALUES + index] :     
        //      (((PROPVARIANT*) ppv)->vt == VT_UI2) ?                           
        //      ((PROPVARIANT*) ppv)->caui.pElems[WIA_LIST_VALUES + index] :     
        //      (((PROPVARIANT*) ppv)->vt == VT_UI4) ?                           
        //      ((PROPVARIANT*) ppv)->caul.pElems[WIA_LIST_VALUES + index] :     
        //      (((PROPVARIANT*) ppv)->vt == VT_I2) ?                            
        //      ((PROPVARIANT*) ppv)->cai.pElems[WIA_LIST_VALUES + index] :      
        //      (((PROPVARIANT*) ppv)->vt == VT_I4) ?                            
        //      ((PROPVARIANT*) ppv)->cal.pElems[WIA_LIST_VALUES + index] :      
        //      (((PROPVARIANT*) ppv)->vt == VT_R4) ?                            
        //      ((PROPVARIANT*) ppv)->caflt.pElems[WIA_LIST_VALUES + index] :    
        //      (((PROPVARIANT*) ppv)->vt == VT_R8) ?                            
        //      ((PROPVARIANT*) ppv)->cadbl.pElems[WIA_LIST_VALUES + index] :    
        //      (((PROPVARIANT*) ppv)->vt == VT_BSTR) ?                          
        //      (LONG)(((PROPVARIANT*) ppv)->cabstr.pElems[WIA_LIST_VALUES + index]) :  
        //      NULL

        //
        // Microsoft defined WIA property offset constants
        //

        public const int WIA_DIP_FIRST = 2;
        public const int WIA_IPA_FIRST = 4098;
        public const int WIA_DPF_FIRST = 3330;
        public const int WIA_IPS_FIRST = 6146;
        public const int WIA_DPS_FIRST = 3074;
        public const int WIA_IPC_FIRST = 5122;
        public const int WIA_NUM_IPC = 9;
        public const int WIA_RESERVED_FOR_NEW_PROPS = 1024;

        //
        // WIA_DPC_WHITE_BALANCE constants
        //

        public const int WHITEBALANCE_MANUAL = 1;
        public const int WHITEBALANCE_AUTO = 2;
        public const int WHITEBALANCE_ONEPUSH_AUTO = 3;
        public const int WHITEBALANCE_DAYLIGHT = 4;
        public const int WHITEBALANCE_FLORESCENT = 5;
        public const int WHITEBALANCE_TUNGSTEN = 6;
        public const int WHITEBALANCE_FLASH = 7;

        //
        // WIA_DPC_FOCUS_MODE constants
        //

        public const int FOCUSMODE_MANUAL = 1;
        public const int FOCUSMODE_AUTO = 2;
        public const int FOCUSMODE_MACROAUTO = 3;

        //
        // WIA_DPC_EXPOSURE_METERING_MODE constants
        //

        public const int EXPOSUREMETERING_AVERAGE = 1;
        public const int EXPOSUREMETERING_CENTERWEIGHT = 2;
        public const int EXPOSUREMETERING_MULTISPOT = 3;
        public const int EXPOSUREMETERING_CENTERSPOT = 4;

        //
        // WIA_DPC_FLASH_MODE constants
        //

        public const int FLASHMODE_AUTO = 1;
        public const int FLASHMODE_OFF = 2;
        public const int FLASHMODE_FILL = 3;
        public const int FLASHMODE_REDEYE_AUTO = 4;
        public const int FLASHMODE_REDEYE_FILL = 5;
        public const int FLASHMODE_EXTERNALSYNC = 6;

        //
        // WIA_DPC_EXPOSURE_MODE constants
        //

        public const int EXPOSUREMODE_MANUAL = 1;
        public const int EXPOSUREMODE_AUTO = 2;
        public const int EXPOSUREMODE_APERTURE_PRIORITY = 3;
        public const int EXPOSUREMODE_SHUTTER_PRIORITY = 4;
        public const int EXPOSUREMODE_PROGRAM_CREATIVE = 5;
        public const int EXPOSUREMODE_PROGRAM_ACTION = 6;
        public const int EXPOSUREMODE_PORTRAIT = 7;

        //
        // WIA_DPC_CAPTURE_MODE constants
        //

        public const int CAPTUREMODE_NORMAL = 1;
        public const int CAPTUREMODE_BURST = 2;
        public const int CAPTUREMODE_TIMELAPSE = 3;

        //
        // WIA_DPC_EFFECT_MODE constants
        //

        public const int EFFECTMODE_STANDARD = 1;
        public const int EFFECTMODE_BW = 2;
        public const int EFFECTMODE_SEPIA = 3;

        //
        // WIA_DPC_FOCUS_METERING_MODE constants
        //

        public const int FOCUSMETERING_CENTERSPOT = 1;
        public const int FOCUSMETERING_MULTISPOT = 2;

        //
        // WIA_DPC_POWER_MODE constants
        //

        public const int POWERMODE_LINE = 1;
        public const int POWERMODE_BATTERY = 2;

        //
        // WIA_DPS_SHEET_FEEDER_REGISTRATION and
        // WIA_DPS_HORIZONTAL_BED_REGISTRATION constants
        //

        public const int LEFT_JUSTIFIED = 0;
        public const int CENTERED = 1;
        public const int RIGHT_JUSTIFIED = 2;

        //
        // WIA_DPS_VERTICAL_BED_REGISTRATION constants
        //

        public const int TOP_JUSTIFIED = 0;
        // public const int CENTERED = 1;
        public const int BOTTOM_JUSTIFIED = 2;

        //
        // WIA_IPS_ORIENTATION and WIA_IPS_ROTATION constants
        //

        public const int PORTRAIT = 0;
        public const int LANSCAPE = 1;
        // // #if (_WIN32_WINNT >= 0x0600)
        public const int LANDSCAPE = LANSCAPE;
        // #endif
        public const int ROT180 = 2;
        public const int ROT270 = 3;


        //
        // WIA_IPS_MIRROR flags
        //

        public const int MIRRORED = 0x01;

        //
        // WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES flags
        //

        public const int FEED = 0x01;
        public const int FLAT = 0x02;
        public const int DUP = 0x04;
        public const int DETECT_FLAT = 0x08;
        public const int DETECT_SCAN = 0x10;
        public const int DETECT_FEED = 0x20;
        public const int DETECT_DUP = 0x40;
        public const int DETECT_FEED_AVAIL = 0x80;
        public const int DETECT_DUP_AVAIL = 0x100;
        // // #if (_WIN32_WINNT >= 0x0600)
        public const int FILM_TPA = 0x200;
        public const int DETECT_FILM_TPA = 0x400;
        public const int STOR = 0x800;
        public const int DETECT_STOR = 0x1000;
        public const int ADVANCED_DUP = 0x2000;
        // #endif

        //
        // WIA_DPS_DOCUMENT_HANDLING_STATUS flags
        //

        public const int FEED_READY = 0x01;
        public const int FLAT_READY = 0x02;
        public const int DUP_READY = 0x04;
        public const int FLAT_COVER_UP = 0x08;
        public const int PATH_COVER_UP = 0x10;
        public const int PAPER_JAM = 0x20;
        // // #if (_WIN32_WINNT >= 0x0600)
        public const int FILM_TPA_READY = 0x40;
        public const int STORAGE_READY = 0x80;
        public const int STORAGE_FULL = 0x100;
        public const int MULTIPLE_FEED = 0x200;
        public const int DEVICE_ATTENTION = 0x400;
        public const int LAMP_ERR = 0x800;
        // #endif

        //
        // WIA_DPS_DOCUMENT_HANDLING_SELECT flags
        //

        public const int FEEDER = 0x001;
        public const int FLATBED = 0x002;
        public const int DUPLEX = 0x004;
        public const int FRONT_FIRST = 0x008;
        public const int BACK_FIRST = 0x010;
        public const int FRONT_ONLY = 0x020;
        public const int BACK_ONLY = 0x040;
        public const int NEXT_PAGE = 0x080;
        public const int PREFEED = 0x100;
        public const int AUTO_ADVANCE = 0x200;
        // // #if (_WIN32_WINNT >= 0x0600)
        //
        // New WIA_IPS_DOCUMENT_HANDLING_SELECT flag
        //
        public const int ADVANCED_DUPLEX = 0x400;
        // #endif //// #if (_WIN32_WINNT >= 0x0600)

        //
        // WIA_DPS_TRANSPARENCY / WIA_DPS_TRANSPARENCY_STATUS flags
        //

        public const int LIGHT_SOURCE_PRESENT_DETECT = 0x01;
        public const int LIGHT_SOURCE_PRESENT = 0x02;
        public const int LIGHT_SOURCE_DETECT_READY = 0x04;
        public const int LIGHT_SOURCE_READY = 0x08;

        //
        // WIA_DPS_TRANSPARENCY_CAPABILITIES
        //

        public const int TRANSPARENCY_DYNAMIC_FRAME_SUPPORT = 0x01;
        public const int TRANSPARENCY_STATIC_FRAME_SUPPORT = 0x02;

        //
        // WIA_DPS_TRANSPARENCY_SELECT flags
        //

        public const int LIGHT_SOURCE_SELECT = 0x001;  // currently not used
        public const int LIGHT_SOURCE_POSITIVE = 0x002;
        public const int LIGHT_SOURCE_NEGATIVE = 0x004;

        //
        // WIA_DPS_SCAN_AHEAD_PAGES constants
        //

        public const int WIA_SCAN_AHEAD_ALL = 0;

        //
        // WIA_DPS_PAGES constants
        //

        public const int ALL_PAGES = 0;

        //
        // WIA_DPS_PREVIEW constants
        //

        public const int WIA_FINAL_SCAN = 0;
        public const int WIA_PREVIEW_SCAN = 1;

        //
        // WIA_DPS_SHOW_PREVIEW_CONTROL constants
        //

        public const int WIA_SHOW_PREVIEW_CONTROL = 0;
        public const int WIA_DONT_SHOW_PREVIEW_CONTROL = 1;

        //
        // Predefined strings for WIA_DPS_ENDORSER_STRING
        //

        public const string WIA_ENDORSER_TOK_DATE = "$DATE$";
        public const string WIA_ENDORSER_TOK_TIME = "$TIME$";
        public const string WIA_ENDORSER_TOK_PAGE_COUNT = "$PAGE_COUNT$";
        public const string WIA_ENDORSER_TOK_DAY = "$DAY$";
        public const string WIA_ENDORSER_TOK_MONTH = "$MONTH$";
        public const string WIA_ENDORSER_TOK_YEAR = "$YEAR$";

        //
        // WIA_DPS_PAGE_SIZE/WIA_IPS_PAGE_SIZE constants
        // Dimensions are defined as (WIDTH x HEIGHT) in 1/1000ths of an inch
        //

        public const int WIA_PAGE_A4 = 0;  //  8267 x 11692
        public const int WIA_PAGE_LETTER = 1;  //  8500 x 11000
        public const int WIA_PAGE_CUSTOM = 2;  // (current extent settings)

        public const int WIA_PAGE_USLEGAL = 3;  //  8500 x 14000
        public const int WIA_PAGE_USLETTER = WIA_PAGE_LETTER;
        public const int WIA_PAGE_USLEDGER = 4;  // 11000 x 17000
        public const int WIA_PAGE_USSTATEMENT = 5;  //  5500 x  8500
        public const int WIA_PAGE_BUSINESSCARD = 6;  //  3543 x  2165

        //
        // ISO A page size constants
        //

        public const int WIA_PAGE_ISO_A0 = 7;  // 33110 x 46811
        public const int WIA_PAGE_ISO_A1 = 8;  // 23385 x 33110
        public const int WIA_PAGE_ISO_A2 = 9;  // 16535 x 23385
        public const int WIA_PAGE_ISO_A3 = 10;  // 11692 x 16535
        public const int WIA_PAGE_ISO_A4 = WIA_PAGE_A4;
        public const int WIA_PAGE_ISO_A5 = 11;  //  5826 x  8267
        public const int WIA_PAGE_ISO_A6 = 12;  //  4133 x  5826
        public const int WIA_PAGE_ISO_A7 = 13;  //  2913 x  4133
        public const int WIA_PAGE_ISO_A8 = 14;  //  2047 x  2913
        public const int WIA_PAGE_ISO_A9 = 15;  //  1456 x  2047
        public const int WIA_PAGE_ISO_A10 = 16;  //  1023 x  1456

        //
        // ISO B page size constants
        //

        public const int WIA_PAGE_ISO_B0 = 17;  //  39370 x 55669
        public const int WIA_PAGE_ISO_B1 = 18;  //  27834 x 39370
        public const int WIA_PAGE_ISO_B2 = 19;  //  19685 x 27834
        public const int WIA_PAGE_ISO_B3 = 20;  //  13897 x 19685
        public const int WIA_PAGE_ISO_B4 = 21;  //   9842 x 13897
        public const int WIA_PAGE_ISO_B5 = 22;  //   6929 x  9842
        public const int WIA_PAGE_ISO_B6 = 23;  //   4921 x  6929
        public const int WIA_PAGE_ISO_B7 = 24;  //   3464 x  4921
        public const int WIA_PAGE_ISO_B8 = 25;  //   2440 x  3464
        public const int WIA_PAGE_ISO_B9 = 26;  //   1732 x  2440
        public const int WIA_PAGE_ISO_B10 = 27;  //   1220 x  1732

        //
        // ISO C page size constants
        //

        public const int WIA_PAGE_ISO_C0 = 28;  //  36102 x 51062
        public const int WIA_PAGE_ISO_C1 = 29;  //  25511 x 36102
        public const int WIA_PAGE_ISO_C2 = 30;  //  18031 x 25511
        public const int WIA_PAGE_ISO_C3 = 31;  //  12755 x 18031
        public const int WIA_PAGE_ISO_C4 = 32;  //   9015 x 12755 (unfolded)
        public const int WIA_PAGE_ISO_C5 = 33;  //   6377 x  9015 (folded once)
        public const int WIA_PAGE_ISO_C6 = 34;  //   4488 x  6377 (folded twice)
        public const int WIA_PAGE_ISO_C7 = 35;  //   3188 x  4488
        public const int WIA_PAGE_ISO_C8 = 36;  //   2244 x  3188
        public const int WIA_PAGE_ISO_C9 = 37;  //   1574 x  2244
        public const int WIA_PAGE_ISO_C10 = 38;  //   1102 x  1574

        //
        // JIS B page size constants
        //

        public const int WIA_PAGE_JIS_B0 = 39;  //  40551 x 57322
        public const int WIA_PAGE_JIS_B1 = 40;  //  28661 x 40551
        public const int WIA_PAGE_JIS_B2 = 41;  //  20275 x 28661
        public const int WIA_PAGE_JIS_B3 = 42;  //  14330 x 20275
        public const int WIA_PAGE_JIS_B4 = 43;  //  10118 x 14330
        public const int WIA_PAGE_JIS_B5 = 44;  //   7165 x 10118
        public const int WIA_PAGE_JIS_B6 = 45;  //   5039 x  7165
        public const int WIA_PAGE_JIS_B7 = 46;  //   3582 x  5039
        public const int WIA_PAGE_JIS_B8 = 47;  //   2519 x  3582
        public const int WIA_PAGE_JIS_B9 = 48;  //   1771 x  2519
        public const int WIA_PAGE_JIS_B10 = 49;  //   1259 x  1771

        //
        // JIS A page size constants
        //

        public const int WIA_PAGE_JIS_2A = 50;  //  46811 x 66220
        public const int WIA_PAGE_JIS_4A = 51;  //  66220 x  93622

        //
        // DIN B page size constants
        //

        public const int WIA_PAGE_DIN_2B = 52;  //  55669 x 78740
        public const int WIA_PAGE_DIN_4B = 53;  //  78740 x 111338

        // // #if (_WIN32_WINNT >= 0x0600)
        //
        // Additional WIA_IPS_PAGE_SIZE constants:
        //
        public const int WIA_PAGE_AUTO = 100;
        public const int WIA_PAGE_CUSTOM_BASE = 0x8000;
        // #endif //// #if (_WIN32_WINNT >= 0x0600)


        //
        // WIA_IPA_COMPRESSION constants
        //

        public const int WIA_COMPRESSION_NONE = 0;
        public const int WIA_COMPRESSION_BI_RLE4 = 1;
        public const int WIA_COMPRESSION_BI_RLE8 = 2;
        public const int WIA_COMPRESSION_G3 = 3;
        public const int WIA_COMPRESSION_G4 = 4;
        public const int WIA_COMPRESSION_JPEG = 5;
        // // #if (_WIN32_WINNT >= 0x0600)
        public const int WIA_COMPRESSION_JBIG = 6;
        public const int WIA_COMPRESSION_JPEG2K = 7;
        public const int WIA_COMPRESSION_PNG = 8;
        // // #endif //// #if (_WIN32_WINNT >= 0x0600)

        //
        // WIA_IPA_PLANAR constants
        //

        public const int WIA_PACKED_PIXEL = 0;
        public const int WIA_PLANAR = 1;

        //
        // WIA_IPA_DATATYPE constants
        //

        public const int WIA_DATA_THRESHOLD = 0;
        public const int WIA_DATA_DITHER = 1;
        public const int WIA_DATA_GRAYSCALE = 2;
        public const int WIA_DATA_COLOR = 3;
        public const int WIA_DATA_COLOR_THRESHOLD = 4;
        public const int WIA_DATA_COLOR_DITHER = 5;
        // // #if (_WIN32_WINNT >= 0x0600)
        public const int WIA_DATA_RAW_RGB = 6;
        public const int WIA_DATA_RAW_BGR = 7;
        public const int WIA_DATA_RAW_YUV = 8;
        public const int WIA_DATA_RAW_YUVK = 9;
        public const int WIA_DATA_RAW_CMY = 10;
        public const int WIA_DATA_RAW_CMYK = 11;
        // // #endif //// #if (_WIN32_WINNT >= 0x0600)


        //
        // WIA_IPS_PHOTOMETRIC_INTERP constants
        //

        public const int WIA_PHOTO_WHITE_1 = 0;  // white is 1, black is 0
        public const int WIA_PHOTO_WHITE_0 = 1;  // white is 0, black is 1

        //
        // WIA_IPA_SUPPRESS_PROPERTY_PAGE flags
        //

        public const int WIA_PROPPAGE_SCANNER_ITEM_GENERAL = 0x00000001;
        public const int WIA_PROPPAGE_CAMERA_ITEM_GENERAL = 0x00000002;
        public const int WIA_PROPPAGE_DEVICE_GENERAL = 0x00000004;

        //
        // WIA_IPS_CUR_INTENT flags
        //
        public const int WIA_INTENT_NONE = 0x00000000;
        public const int WIA_INTENT_IMAGE_TYPE_COLOR = 0x00000001;
        public const int WIA_INTENT_IMAGE_TYPE_GRAYSCALE = 0x00000002;
        public const int WIA_INTENT_IMAGE_TYPE_TEXT = 0x00000004;
        public const int WIA_INTENT_IMAGE_TYPE_MASK = 0x0000000F;
        public const int WIA_INTENT_MINIMIZE_SIZE = 0x00010000;
        public const int WIA_INTENT_MAXIMIZE_QUALITY = 0x00020000;
        public const int WIA_INTENT_BEST_PREVIEW = 0x00040000;
        public const int WIA_INTENT_SIZE_MASK = 0x000F0000;

        //
        // global WIA device informationproperty array
        //

        public const int WIA_NUM_DIP = 16;

        // // #ifdef WIA_DECLARE_DEVINFO_PROP_ARRAY

        // PROPSPEC g_psDeviceInfo[WIA_NUM_DIP] =
        // {
        //     {PRSPEC_PROPID, WIA_DIP_DEV_ID},
        //     {PRSPEC_PROPID, WIA_DIP_VEND_DESC},
        //     {PRSPEC_PROPID, WIA_DIP_DEV_DESC},
        //     {PRSPEC_PROPID, WIA_DIP_DEV_TYPE},
        //     {PRSPEC_PROPID, WIA_DIP_PORT_NAME},
        //     {PRSPEC_PROPID, WIA_DIP_DEV_NAME},
        //     {PRSPEC_PROPID, WIA_DIP_SERVER_NAME},
        //     {PRSPEC_PROPID, WIA_DIP_REMOTE_DEV_ID},
        //     {PRSPEC_PROPID, WIA_DIP_UI_CLSID},
        //     {PRSPEC_PROPID, WIA_DIP_HW_CONFIG},
        //     {PRSPEC_PROPID, WIA_DIP_BAUDRATE},
        //     {PRSPEC_PROPID, WIA_DIP_STI_GEN_CAPABILITIES},
        //     {PRSPEC_PROPID, WIA_DIP_WIA_VERSION},
        //     {PRSPEC_PROPID, WIA_DIP_DRIVER_VERSION},
        //     {PRSPEC_PROPID, WIA_DIP_PNP_ID},
        //     {PRSPEC_PROPID, WIA_DIP_STI_DRIVER_VERSION},
        // };

        // PROPID g_piDeviceInfo[WIA_NUM_DIP] =
        // {
        //     WIA_DIP_DEV_ID,
        //     WIA_DIP_VEND_DESC,
        //     WIA_DIP_DEV_DESC,
        //     WIA_DIP_DEV_TYPE,
        //     WIA_DIP_PORT_NAME,
        //     WIA_DIP_DEV_NAME,
        //     WIA_DIP_SERVER_NAME,
        //     WIA_DIP_REMOTE_DEV_ID,
        //     WIA_DIP_UI_CLSID,
        //     WIA_DIP_HW_CONFIG,
        //     WIA_DIP_BAUDRATE,
        //     WIA_DIP_STI_GEN_CAPABILITIES,
        //     WIA_DIP_WIA_VERSION,
        //     WIA_DIP_DRIVER_VERSION,
        //     WIA_DIP_PNP_ID,
        //     WIA_DIP_STI_DRIVER_VERSION,
        // };

        // LPOLESTR g_pszDeviceInfo[WIA_NUM_DIP] =
        // {
        //     WIA_DIP_DEV_ID_STR,
        //     WIA_DIP_VEND_DESC_STR,
        //     WIA_DIP_DEV_DESC_STR,
        //     WIA_DIP_DEV_TYPE_STR,
        //     WIA_DIP_PORT_NAME_STR,
        //     WIA_DIP_DEV_NAME_STR,
        //     WIA_DIP_SERVER_NAME_STR,
        //     WIA_DIP_REMOTE_DEV_ID_STR,
        //     WIA_DIP_UI_CLSID_STR,
        //     WIA_DIP_HW_CONFIG_STR,
        //     WIA_DIP_BAUDRATE_STR,
        //     WIA_DIP_STI_GEN_CAPABILITIES_STR,
        //     WIA_DIP_WIA_VERSION_STR,
        //     WIA_DIP_DRIVER_VERSION_STR,
        //     WIA_DIP_PNP_ID_STR,
        //     WIA_DIP_STI_DRIVER_VERSION_STR,
        // };

        //#else

        // extern PROPSPEC g_psDeviceInfo[WIA_NUM_DIP];
        // extern PROPID   g_piDeviceInfo[WIA_NUM_DIP];
        // extern LPOLESTR g_pszDeviceInfo[WIA_NUM_DIP];

        // #endif

        //
        // global WIA property ID to property name array
        //

        // // #ifdef DEFINE_WIA_PROPID_TO_NAME

        public Dictionary<int, string> WIA_PROPID_TO_NAME = new Dictionary<int, string>()
{
    {WIA_DIP_DEV_ID,                          WIA_DIP_DEV_ID_STR},
    {WIA_DIP_VEND_DESC,                       WIA_DIP_VEND_DESC_STR},
    {WIA_DIP_DEV_DESC,                        WIA_DIP_DEV_DESC_STR},
    {WIA_DIP_DEV_TYPE,                        WIA_DIP_DEV_TYPE_STR},
    {WIA_DIP_PORT_NAME,                       WIA_DIP_PORT_NAME_STR},
    {WIA_DIP_DEV_NAME,                        WIA_DIP_DEV_NAME_STR},
    {WIA_DIP_SERVER_NAME,                     WIA_DIP_SERVER_NAME_STR},
    {WIA_DIP_REMOTE_DEV_ID,                   WIA_DIP_REMOTE_DEV_ID_STR},
    {WIA_DIP_UI_CLSID,                        WIA_DIP_UI_CLSID_STR},
    {WIA_DIP_HW_CONFIG,                       WIA_DIP_HW_CONFIG_STR},
    {WIA_DIP_BAUDRATE,                        WIA_DIP_BAUDRATE_STR},
    {WIA_DIP_STI_GEN_CAPABILITIES,            WIA_DIP_STI_GEN_CAPABILITIES_STR},
    {WIA_DIP_WIA_VERSION,                     WIA_DIP_WIA_VERSION_STR},
    {WIA_DIP_DRIVER_VERSION,                  WIA_DIP_DRIVER_VERSION_STR},
    {WIA_DIP_PNP_ID,                          WIA_DIP_PNP_ID_STR},
    {WIA_DIP_STI_DRIVER_VERSION,              WIA_DIP_STI_DRIVER_VERSION_STR},
    {WIA_DPA_FIRMWARE_VERSION,                WIA_DPA_FIRMWARE_VERSION_STR},
    {WIA_DPA_CONNECT_STATUS,                  WIA_DPA_CONNECT_STATUS_STR},
    {WIA_DPA_DEVICE_TIME,                     WIA_DPA_DEVICE_TIME_STR},
    {WIA_DPC_PICTURES_TAKEN,                  WIA_DPC_PICTURES_TAKEN_STR},
    {WIA_DPC_PICTURES_REMAINING,              WIA_DPC_PICTURES_REMAINING_STR},
    {WIA_DPC_EXPOSURE_MODE,                   WIA_DPC_EXPOSURE_MODE_STR},
    {WIA_DPC_EXPOSURE_COMP,                   WIA_DPC_EXPOSURE_COMP_STR},
    {WIA_DPC_EXPOSURE_TIME,                   WIA_DPC_EXPOSURE_TIME_STR},
    {WIA_DPC_FNUMBER,                         WIA_DPC_FNUMBER_STR},
    {WIA_DPC_FLASH_MODE,                      WIA_DPC_FLASH_MODE_STR},
    {WIA_DPC_FOCUS_MODE,                      WIA_DPC_FOCUS_MODE_STR},
    {WIA_DPC_FOCUS_MANUAL_DIST,               WIA_DPC_FOCUS_MANUAL_DIST_STR},
    {WIA_DPC_ZOOM_POSITION,                   WIA_DPC_ZOOM_POSITION_STR},
    {WIA_DPC_PAN_POSITION,                    WIA_DPC_PAN_POSITION_STR},
    {WIA_DPC_TILT_POSITION,                   WIA_DPC_TILT_POSITION_STR},
    {WIA_DPC_TIMER_MODE,                      WIA_DPC_TIMER_MODE_STR},
    {WIA_DPC_TIMER_VALUE,                     WIA_DPC_TIMER_VALUE_STR},
    {WIA_DPC_POWER_MODE,                      WIA_DPC_POWER_MODE_STR},
    {WIA_DPC_BATTERY_STATUS,                  WIA_DPC_BATTERY_STATUS_STR},
    {WIA_DPC_DIMENSION,                       WIA_DPC_DIMENSION_STR},
    {WIA_DPS_HORIZONTAL_BED_SIZE,             WIA_DPS_HORIZONTAL_BED_SIZE_STR},
    {WIA_DPS_VERTICAL_BED_SIZE,               WIA_DPS_VERTICAL_BED_SIZE_STR},
    {WIA_DPS_HORIZONTAL_SHEET_FEED_SIZE,      WIA_DPS_HORIZONTAL_SHEET_FEED_SIZE_STR},
    {WIA_DPS_VERTICAL_SHEET_FEED_SIZE,        WIA_DPS_VERTICAL_SHEET_FEED_SIZE_STR},
    {WIA_DPS_SHEET_FEEDER_REGISTRATION,       WIA_DPS_SHEET_FEEDER_REGISTRATION_STR},
    {WIA_DPS_HORIZONTAL_BED_REGISTRATION,     WIA_DPS_HORIZONTAL_BED_REGISTRATION_STR},
    {WIA_DPS_VERTICAL_BED_REGISTRATION,       WIA_DPS_VERTICAL_BED_REGISTRATION_STR},
    {WIA_DPS_PLATEN_COLOR,                    WIA_DPS_PLATEN_COLOR_STR},
    {WIA_DPS_PAD_COLOR,                       WIA_DPS_PAD_COLOR_STR},
    {WIA_DPS_FILTER_SELECT,                   WIA_DPS_FILTER_SELECT_STR},
    {WIA_DPS_DITHER_SELECT,                   WIA_DPS_DITHER_SELECT_STR},
    {WIA_DPS_DITHER_PATTERN_DATA,             WIA_DPS_DITHER_PATTERN_DATA_STR},
    {WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES,  WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES_STR},
    {WIA_DPS_DOCUMENT_HANDLING_STATUS,        WIA_DPS_DOCUMENT_HANDLING_STATUS_STR},
    {WIA_DPS_DOCUMENT_HANDLING_SELECT,        WIA_DPS_DOCUMENT_HANDLING_SELECT_STR},
    {WIA_DPS_DOCUMENT_HANDLING_CAPACITY,      WIA_DPS_DOCUMENT_HANDLING_CAPACITY_STR},
    {WIA_DPS_OPTICAL_XRES,                    WIA_DPS_OPTICAL_XRES_STR},
    {WIA_DPS_OPTICAL_YRES,                    WIA_DPS_OPTICAL_YRES_STR},
    {WIA_DPS_ENDORSER_CHARACTERS,             WIA_DPS_ENDORSER_CHARACTERS_STR},
    {WIA_DPS_ENDORSER_STRING,                 WIA_DPS_ENDORSER_STRING_STR},
    {WIA_DPS_SCAN_AHEAD_PAGES,                WIA_DPS_SCAN_AHEAD_PAGES_STR},
    {WIA_DPS_MAX_SCAN_TIME,                   WIA_DPS_MAX_SCAN_TIME_STR},
    {WIA_DPS_PAGES,                           WIA_DPS_PAGES_STR},
    {WIA_DPS_PAGE_SIZE,                       WIA_DPS_PAGE_SIZE_STR},
    {WIA_DPS_PAGE_WIDTH,                      WIA_DPS_PAGE_WIDTH_STR},
    {WIA_DPS_PAGE_HEIGHT,                     WIA_DPS_PAGE_HEIGHT_STR},
    {WIA_DPS_PREVIEW,                         WIA_DPS_PREVIEW_STR},
    {WIA_DPS_TRANSPARENCY,                    WIA_DPS_TRANSPARENCY_STR},
    {WIA_DPS_TRANSPARENCY_SELECT,             WIA_DPS_TRANSPARENCY_SELECT_STR},
    {WIA_DPS_SHOW_PREVIEW_CONTROL,            WIA_DPS_SHOW_PREVIEW_CONTROL_STR},
    {WIA_DPS_MIN_HORIZONTAL_SHEET_FEED_SIZE,  WIA_DPS_MIN_HORIZONTAL_SHEET_FEED_SIZE_STR},
    {WIA_DPS_MIN_VERTICAL_SHEET_FEED_SIZE,    WIA_DPS_MIN_VERTICAL_SHEET_FEED_SIZE_STR},
    {WIA_DPS_USER_NAME,                       WIA_DPS_USER_NAME_STR},
    {WIA_DPV_LAST_PICTURE_TAKEN,              WIA_DPV_LAST_PICTURE_TAKEN_STR},
    {WIA_DPV_IMAGES_DIRECTORY,                WIA_DPV_IMAGES_DIRECTORY_STR},
    {WIA_DPV_DSHOW_DEVICE_PATH,               WIA_DPV_DSHOW_DEVICE_PATH_STR},
    {WIA_DPF_MOUNT_POINT,                     WIA_DPF_MOUNT_POINT_STR},
    {WIA_IPA_ITEM_NAME,                       WIA_IPA_ITEM_NAME_STR},
    {WIA_IPA_FULL_ITEM_NAME,                  WIA_IPA_FULL_ITEM_NAME_STR},
    {WIA_IPA_ITEM_TIME,                       WIA_IPA_ITEM_TIME_STR},
    {WIA_IPA_ITEM_FLAGS,                      WIA_IPA_ITEM_FLAGS_STR},
    {WIA_IPA_ACCESS_RIGHTS,                   WIA_IPA_ACCESS_RIGHTS_STR},
    {WIA_IPA_DATATYPE,                        WIA_IPA_DATATYPE_STR},
    {WIA_IPA_DEPTH,                           WIA_IPA_DEPTH_STR},
    {WIA_IPA_PREFERRED_FORMAT,                WIA_IPA_PREFERRED_FORMAT_STR},
    {WIA_IPA_FORMAT,                          WIA_IPA_FORMAT_STR},
    {WIA_IPA_COMPRESSION,                     WIA_IPA_COMPRESSION_STR},
    {WIA_IPA_TYMED,                           WIA_IPA_TYMED_STR},
    {WIA_IPA_CHANNELS_PER_PIXEL,              WIA_IPA_CHANNELS_PER_PIXEL_STR},
    {WIA_IPA_BITS_PER_CHANNEL,                WIA_IPA_BITS_PER_CHANNEL_STR},
    {WIA_IPA_PLANAR,                          WIA_IPA_PLANAR_STR},
    {WIA_IPA_PIXELS_PER_LINE,                 WIA_IPA_PIXELS_PER_LINE_STR},
    {WIA_IPA_BYTES_PER_LINE,                  WIA_IPA_BYTES_PER_LINE_STR},
    {WIA_IPA_NUMBER_OF_LINES,                 WIA_IPA_NUMBER_OF_LINES_STR},
    {WIA_IPA_GAMMA_CURVES,                    WIA_IPA_GAMMA_CURVES_STR},
    {WIA_IPA_ITEM_SIZE,                       WIA_IPA_ITEM_SIZE_STR},
    {WIA_IPA_COLOR_PROFILE,                   WIA_IPA_COLOR_PROFILE_STR},
    {WIA_IPA_MIN_BUFFER_SIZE,                 WIA_IPA_MIN_BUFFER_SIZE_STR},
    {WIA_IPA_REGION_TYPE,                     WIA_IPA_REGION_TYPE_STR},
    {WIA_IPA_ICM_PROFILE_NAME,                WIA_IPA_ICM_PROFILE_NAME_STR},
    {WIA_IPA_APP_COLOR_MAPPING,               WIA_IPA_APP_COLOR_MAPPING_STR},
    {WIA_IPA_PROP_STREAM_COMPAT_ID,           WIA_IPA_PROP_STREAM_COMPAT_ID_STR},
    {WIA_IPA_FILENAME_EXTENSION,              WIA_IPA_FILENAME_EXTENSION_STR},
    {WIA_IPA_SUPPRESS_PROPERTY_PAGE,          WIA_IPA_SUPPRESS_PROPERTY_PAGE_STR},
    {WIA_IPC_THUMBNAIL,                       WIA_IPC_THUMBNAIL_STR},
    {WIA_IPC_THUMB_WIDTH,                     WIA_IPC_THUMB_WIDTH_STR},
    {WIA_IPC_THUMB_HEIGHT,                    WIA_IPC_THUMB_HEIGHT_STR},
    {WIA_IPC_AUDIO_AVAILABLE,                 WIA_IPC_AUDIO_AVAILABLE_STR},
    {WIA_IPC_AUDIO_DATA_FORMAT,               WIA_IPC_AUDIO_DATA_FORMAT_STR},
    {WIA_IPC_AUDIO_DATA,                      WIA_IPC_AUDIO_DATA_STR},
    {WIA_IPC_NUM_PICT_PER_ROW,                WIA_IPC_NUM_PICT_PER_ROW_STR},
    {WIA_IPC_SEQUENCE,                        WIA_IPC_SEQUENCE_STR},
    {WIA_IPC_TIMEDELAY,                       WIA_IPC_TIMEDELAY_STR},
    {WIA_IPS_CUR_INTENT,                      WIA_IPS_CUR_INTENT_STR},
    {WIA_IPS_XRES,                            WIA_IPS_XRES_STR},
    {WIA_IPS_YRES,                            WIA_IPS_YRES_STR},
    {WIA_IPS_XPOS,                            WIA_IPS_XPOS_STR},
    {WIA_IPS_YPOS,                            WIA_IPS_YPOS_STR},
    {WIA_IPS_XEXTENT,                         WIA_IPS_XEXTENT_STR},
    {WIA_IPS_YEXTENT,                         WIA_IPS_YEXTENT_STR},
    {WIA_IPS_PHOTOMETRIC_INTERP,              WIA_IPS_PHOTOMETRIC_INTERP_STR},
    {WIA_IPS_BRIGHTNESS,                      WIA_IPS_BRIGHTNESS_STR},
    {WIA_IPS_CONTRAST,                        WIA_IPS_CONTRAST_STR},
    {WIA_IPS_ORIENTATION,                     WIA_IPS_ORIENTATION_STR},
    {WIA_IPS_ROTATION,                        WIA_IPS_ROTATION_STR},
    {WIA_IPS_MIRROR,                          WIA_IPS_MIRROR_STR},
    {WIA_IPS_THRESHOLD,                       WIA_IPS_THRESHOLD_STR},
    {WIA_IPS_INVERT,                          WIA_IPS_INVERT_STR},
    {WIA_IPS_WARM_UP_TIME,                    WIA_IPS_WARM_UP_TIME_STR},
// // #if (_WIN32_WINNT >= 0x0600)
    {WIA_IPA_ITEM_CATEGORY,                   WIA_IPA_ITEM_CATEGORY_STR},
    {WIA_IPA_RAW_BITS_PER_CHANNEL,            WIA_IPA_RAW_BITS_PER_CHANNEL_STR},
    {WIA_IPS_DESKEW_X,                        WIA_IPS_DESKEW_X_STR},
    {WIA_IPS_DESKEW_Y,                        WIA_IPS_DESKEW_Y_STR},
    {WIA_IPS_SEGMENTATION,                    WIA_IPS_SEGMENTATION_STR},
    {WIA_IPS_MAX_HORIZONTAL_SIZE,             WIA_IPS_MAX_HORIZONTAL_SIZE_STR},
    {WIA_IPS_MAX_VERTICAL_SIZE,               WIA_IPS_MAX_VERTICAL_SIZE_STR},
    {WIA_IPS_MIN_HORIZONTAL_SIZE,             WIA_IPS_MIN_HORIZONTAL_SIZE_STR},
    {WIA_IPS_MIN_VERTICAL_SIZE,               WIA_IPS_MIN_VERTICAL_SIZE_STR},
    {WIA_IPS_SHEET_FEEDER_REGISTRATION,       WIA_IPS_SHEET_FEEDER_REGISTRATION_STR},
    {WIA_IPS_DOCUMENT_HANDLING_SELECT,        WIA_IPS_DOCUMENT_HANDLING_SELECT_STR},
    {WIA_IPS_OPTICAL_XRES,                    WIA_IPS_OPTICAL_XRES_STR},
    {WIA_IPS_OPTICAL_YRES,                    WIA_IPS_OPTICAL_YRES_STR},
    {WIA_IPS_PAGES,                           WIA_IPS_PAGES_STR},
    {WIA_IPS_PAGE_SIZE,                       WIA_IPS_PAGE_SIZE_STR},
    {WIA_IPS_PAGE_WIDTH,                      WIA_IPS_PAGE_WIDTH_STR},
    {WIA_IPS_PAGE_HEIGHT,                     WIA_IPS_PAGE_HEIGHT_STR},
    {WIA_IPS_PREVIEW,                         WIA_IPS_PREVIEW_STR},
    {WIA_IPS_SHOW_PREVIEW_CONTROL,            WIA_IPS_SHOW_PREVIEW_CONTROL_STR},
    {WIA_IPS_TRANSFER_CAPABILITIES,           WIA_IPS_TRANSFER_CAPABILITIES_STR},
    {WIA_IPS_FILM_SCAN_MODE,                  WIA_IPS_FILM_SCAN_MODE_STR}, 
    {WIA_IPS_LAMP,                            WIA_IPS_LAMP_STR},
    {WIA_IPS_LAMP_AUTO_OFF,                   WIA_IPS_LAMP_AUTO_OFF_STR}, 
    {WIA_IPS_AUTO_DESKEW,                     WIA_IPS_AUTO_DESKEW_STR},
    {WIA_IPS_SUPPORTS_CHILD_ITEM_CREATION,    WIA_IPS_SUPPORTS_CHILD_ITEM_CREATION_STR},
    {WIA_IPS_PREVIEW_TYPE,                    WIA_IPS_PREVIEW_TYPE_STR},
    {WIA_IPS_XSCALING,                        WIA_IPS_XSCALING_STR},
    {WIA_IPS_YSCALING,                        WIA_IPS_YSCALING_STR},
    {WIA_IPA_UPLOAD_ITEM_SIZE,                WIA_IPA_UPLOAD_ITEM_SIZE_STR},
    {WIA_IPA_ITEMS_STORED,                    WIA_IPA_ITEMS_STORED_STR},
// // #endif
    {0,                                       "Not a WIA property"}
};

        // #else

        // extern WIA_PROPID_TO_NAME g_wiaPropIdToName[];

        // // #endif

        // // #ifdef __cplusplus
        // };
        // // #endif

        // #include <poppack.h>

        // // #endif // _WIADEF_

        // // #endif //// #if (_WIN32_WINNT >= 0x0501)


    }
}
