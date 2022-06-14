using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedWindowsUtility
{
    public class Windows
    {
        /// <summary>
        /// This synchronous function returns the amount of memory available based on the package parameter you provide.
        /// </summary>
        /// <param name="type">Packet Type</param>
        /// <returns>availableSpace(decimal)</returns>
        /// <exception cref="WindowsServiceException"></exception>
        public static decimal GetAvailableMemorySpace(string type)
        {
            try
            {
                decimal availableSpace = default;
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PerfFormattedData_PerfOS_Memory");
                    
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (type == "GBytes") 
                        availableSpace = Convert.ToDecimal(queryObj[$"AvailableMBytes"]) / 1024;

                    else
                        availableSpace = Convert.ToDecimal(queryObj[$"Available{type}"]);
                }

                if (type == "GBytes")              
                    return Decimal.Round(availableSpace, 2);

                else 
                    return availableSpace;

            }
            catch (ManagementException e)
            {
                throw new WindowsServiceException($"A problem was encountered with the mathematical operations or the {type} parameter you entered.");
            }
        }

        /// <summary>
        /// This synchronous function returns whether the application name you have given is open in transactions.
        /// </summary>
        /// <param name="procParam">Target Process Parameter</param>
        /// <returns>true or false</returns>
        /// <exception cref="WindowsServiceException"></exception>
        public static bool IsRunningProcess(string procParam)
        {
            try
            {
                bool isRunningProcess = default;
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Process");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (Equals(queryObj["Name"], procParam))
                    {
                        isRunningProcess = true;
                        break;
                    }
                }

                return isRunningProcess;
            }
            catch (ManagementException e)
            {
                throw new WindowsServiceException($"An error occurred while searching for a {procParam} process parameter.");
            }
        }


        /// <summary>
        /// This synchronous function returns the registered user information via Win32_OS.
        /// </summary>
        /// <returns>example@domain.com</returns>
        /// <exception cref="WindowsServiceException"></exception>
        public static string GetRegisteredMail()
        {
            try
            {
                string registeredMail = default;
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                    registeredMail = queryObj["RegisteredUser"].ToString();

                return registeredMail;
            }
            catch (ManagementException e)
            {
                throw new WindowsServiceException("An error occurred while searching for a registered user.");
            }
        }

        /// <summary>
        /// This synchronous function that returns the full name of your operating system from string type using WMI (Win32API).
        /// </summary>
        /// <returns>Operating System Full Name (string)</returns>
        /// <exception cref="WindowsServiceException"></exception>
        public static string GetOperatingSystemName()
        {
            try
            {
                string operatingSystemName = default;
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                     "SELECT * FROM Win32_OperatingSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                    operatingSystemName = Convert.ToString(queryObj["Caption"]);

                return operatingSystemName;
            }
            catch (Exception)
            {
                throw new WindowsServiceException("An error occurred while searching for a Operating System name.");
            }

        }

        /// <summary>
        /// It is a synchronous function that returns the user name of your device from string type using the Environment class.
        /// </summary>
        /// <returns>Microsoft.Windows.Username (string)</returns>
        /// <exception cref="WindowsServiceException"></exception>
        public static string GetUsername()
        {
            try
            {
                return Environment.UserName;
            }
            catch (Exception)
            {
                throw new WindowsServiceException("An error occurred while searching for a Username.");
            }
        }

        /// <summary>
        /// This asynchronous function returns the amount of memory available based on the package parameter you provide.
        /// </summary>
        /// <param name="type">Packet Type</param>
        /// <returns>availableSpace(decimal)</returns>
        /// <exception cref="WindowsServiceException"></exception>
        public static Task<decimal> GetAvailableMemorySpaceAsync(string type)
        {
            try
            {
                decimal availableSpace = default;
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PerfFormattedData_PerfOS_Memory");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (type == "GBytes")
                        availableSpace = Convert.ToDecimal(queryObj[$"AvailableMBytes"]) / 1024;

                    else
                        availableSpace = Convert.ToDecimal(queryObj[$"Available{type}"]);
                }

                if (type == "GBytes")
                    return Task.FromResult<decimal>(Decimal.Round(availableSpace, 2));

                else
                    return Task.FromResult<decimal>(availableSpace);

            }
            catch (ManagementException e)
            {
                throw new WindowsServiceException($"A problem was encountered with the mathematical operations or the {type} parameter you entered.");
            }
        }

        /// <summary>
        /// This asynchronous function returns whether the application name you have given is open in transactions.
        /// </summary>
        /// <param name="procParam">Target Process Parameter</param>
        /// <returns>true or false</returns>
        /// <exception cref="WindowsServiceException"></exception>
        public static Task<bool> IsRunningProcessAsync(string procParam)
        {
            try
            {
                bool isRunningProcess = default;
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Process");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (Equals(queryObj["Name"], procParam))
                    {
                        isRunningProcess = true;
                        break;
                    }
                }

                return Task.FromResult<bool>(isRunningProcess);
            }
            catch (ManagementException e)
            {
                throw new WindowsServiceException($"An error occurred while searching for a {procParam} process parameter.");
            }
        }

        /// <summary>
        /// This asynchronous function returns the registered user information via Win32_OS.
        /// </summary>
        /// <returns>example@domain.com</returns>
        /// <exception cref="WindowsServiceException"></exception>
        public static Task<string> GetRegisteredMailAsync()
        {
            try
            {
                string registeredMail = default;
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                    registeredMail = queryObj["RegisteredUser"].ToString();

                return Task.FromResult<string>(registeredMail);
            }
            catch (ManagementException e)
            {
                throw new WindowsServiceException("An error occurred while searching for a registered user.");
            }
        }

        /// <summary>
        /// It is a asynchronous function that returns the full name of your operating system from string type using WMI (Win32API).
        /// </summary>
        /// <returns>Operating System Full Name (string)</returns>
        /// <exception cref="WindowsServiceException"></exception>
        public static Task<string> GetOperatingSystemNameAsync()
        {
            try
            {
                var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                            select x.GetPropertyValue("Caption")).FirstOrDefault();
                return Task.FromResult<string>(name!= null ? name.ToString() : "Unknown");
            }
            catch (Exception)
            {
                throw new WindowsServiceException("An error occurred while searching for a Operating System name.");
            }
        }

        /// <summary>
        /// It is a asynchronous function that returns the user name of your device from string type using the Environment class.
        /// </summary>
        /// <returns>Microsoft.Windows.Username (string)</returns>
        /// <exception cref="WindowsServiceException"></exception>
        public static Task<string> GetUsernameAsync()
        {
            return Task.FromResult<string>(Environment.UserName);
        }
    }

    public class WindowsServiceException : Exception
    {
        public WindowsServiceException() { }
        public WindowsServiceException(object message) : base(message.ToString()) { }
    } 
}