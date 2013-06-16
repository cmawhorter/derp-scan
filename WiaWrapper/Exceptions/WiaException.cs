using System;

namespace DerpScan.WiaWrapper.Exceptions
{
	public class WiaException : Exception
	{
		public int ErrorCode { get; private set; }

		public WiaException(string message, int errorCode, Exception innerException)
			: base(message, innerException)
		{
			ErrorCode = errorCode;
		}

        public static string ErrorMessageFromCode(int errorCode) 
        {
            switch ((uint)errorCode)
            {
                case WiaDef.WIA_ERROR_GENERAL_ERROR:
                    return "General Error";
                case WiaDef.WIA_ERROR_PAPER_JAM:
                    return "Paper Jam";
                case WiaDef.WIA_ERROR_PAPER_EMPTY:
                    return "Paper is Empty.  No paper to scan";
                case WiaDef.WIA_ERROR_PAPER_PROBLEM:
                    return "Paper Problem.  Check paper";
                case WiaDef.WIA_ERROR_OFFLINE:
                    return "Scanner Offline";
                case WiaDef.WIA_ERROR_BUSY:
                    return "Scanner Busy";
                case WiaDef.WIA_ERROR_WARMING_UP:
                    return "Warming Up";
                case WiaDef.WIA_ERROR_USER_INTERVENTION:
                    return "User Cancelled";
                case WiaDef.WIA_ERROR_ITEM_DELETED:
                    return "Item Deleted";
                case WiaDef.WIA_ERROR_DEVICE_COMMUNICATION:
                    return "Problem Communicating with Device";
                case WiaDef.WIA_ERROR_INVALID_COMMAND:
                    return "Invalid Command";
                case WiaDef.WIA_ERROR_INCORRECT_HARDWARE_SETTING:
                    return "Hardware Setting";
                case WiaDef.WIA_ERROR_DEVICE_LOCKED:
                    return "Device Locked";
                case WiaDef.WIA_ERROR_EXCEPTION_IN_DRIVER:
                    return "Exception in Driver";
                case WiaDef.WIA_ERROR_INVALID_DRIVER_RESPONSE:
                    return "Invalid Driver Response";
                case WiaDef.WIA_ERROR_COVER_OPEN:
                    return "Cover Open";
                case WiaDef.WIA_ERROR_LAMP_OFF:
                    return "Lamp Off";
                case WiaDef.WIA_ERROR_DESTINATION:
                    return "Bad Destination";
                case WiaDef.WIA_ERROR_NETWORK_RESERVATION_FAILED:
                    return "Network Reservation Failed";
                case WiaDef.WIA_STATUS_END_OF_MEDIA:
                    return "End of Media";
            }

            return "Unknown Error";
        }
	}
}
