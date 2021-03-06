﻿<p align="center">
  <img src="https://cdn.rawgit.com/iAJTin/iSMBIOS/master/nuget/iSMBIOS.png"  
       height="32">
</p>
<p align="center">
  <a href="https://github.com/iAJTin/iSMBIOS">
    <img src="https://img.shields.io/badge/iTin-iSMBIOS-green.svg?style=flat"/>
  </a>
</p>

***

# What is iSMBIOS?
iSMBIOS is a lightweight implementation that allows us to obtain the SMBIOS information

This library fully implements DMTF Specification 3.2.0 and olders versions

For more information, please see [https://www.dmtf.org/standards/smbios](https://www.dmtf.org/standards/smbios)

# Install via NuGet

<table>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iSMBIOS/tree/master/src/iTin.Core.Hardware">
        <img src="https://img.shields.io/badge/-iSMBIOS-green.svg?style=flat"/>
      </a>
    </td>
    <td>
      <a href="https://www.nuget.org/packages/iSMBIOS/">
        <img alt="NuGet Version" 
             src="https://img.shields.io/nuget/v/iSMBIOS.svg" /> 
      </a>
    </td>  
  </tr>
</table>

# Usage

Call **DMI.Instance.Structures** for getting all SMBIOS structures availables.

## Examples

1. Gets and prints all **SMBIOS** availables structures.


       DmiStructureCollection structures = DMI.Instance.Structures;
       foreach (DmiStructure structure in structures)
       {
           Console.WriteLine($"{(int) structure.Class:D3}-{structure.Class}");
       }

2. Gets a specific **SMBIOS** structure.


       DmiStructureCollection structures = DMI.Instance.Structures;
       DmiStructure bios = structures[SmbiosStructure.Bios];
       if (bios != null)
       {
           /// structure exist!!!
       }

3. Gets a **single property** directly.


       DmiStructureCollection structures = DMI.Instance.Structures;
       object biosVersion = structures.GetProperty(DmiProperty.Bios.BiosVersion);
       if (biosVersion != null)
       {
           Console.WriteLine($" BIOS Version > {biosVersion}");
       }

       string biosVendor = structures.GetProperty<string>(DmiProperty.Bios.Vendor);
       Console.WriteLine($" > BIOS Vendor > {biosVendor}");

	   string processorFamily = structures.GetProperty<string>(DmiProperty.Processor.Family);
       Console.WriteLine($" Processor Family > {processorFamily}");

	   string processorManufacturer = structures.GetProperty<string>(DmiProperty.Processor.ProcessorManufacturer);
       Console.WriteLine($" Processor Manufacturer > {processorManufacturer}");

4. Gets a property in **multiple** elements directly.

       // Requires that the Slot Information structure exists in your system
       DmiStructureCollection structures = DMI.Instance.Structures;
       IDictionary<int, object> systemSlots = structures.GetProperties(DmiProperty.SystemSlots.SlotId);
       foreach (KeyValuePair<int, object> systemSlot in systemSlots)
       {
           int element = systemSlot.Key;
           object property = systemSlot.Value;
           Console.WriteLine($" System Slot ({element}) > {property}");
       }

5. Prints all **SMBIOS** structures properties

       DmiStructureCollection structures = DMI.Instance.Structures;
       foreach (DmiStructure structure in structures)
       {
           DmiStructureClass currentClass = structure.Class;
	   
           Console.WriteLine();
           Console.WriteLine($" —————————————————————————————————————————— DMI ({DMI.AccessType}) —");
           Console.WriteLine($" {(int)currentClass:D3}-{currentClass} structure detail");
           Console.WriteLine($" ——————————————————————————————————————————————————————————————");
           DmiClassCollection elements = structure.Elements;
           foreach (DmiClass element in elements)
           {
               Hashtable elementProperties = element.Properties;
               foreach (DictionaryEntry property in elementProperties)
               {
                   object value = property.Value;

                   PropertyKey key = (PropertyKey)property.Key;
                   Enum id = key.PropertyId;

                   PropertyUnit valueUnit = key.PropertyUnit;
                   string unit =
                       valueUnit == PropertyUnit.None
                           ? string.Empty
                           : valueUnit.ToString();

                   if (value == null)
                   {
                       Console.WriteLine($"{id} > NULL");
                       continue;
                   }

                   if (value is string)
                   {
                       Console.WriteLine($"   > {id} > {value} {unit}");
                   }
                   else if (value is byte)
                   {
                       Console.WriteLine($"   > {id} > {value}{unit} [{value:X2}h]");
                   }
                   else if (value is short)
                   {
                       Console.WriteLine($"   > {id} > {value}{unit} [{value:X4}h]");
                   }
                   else if (value is ushort)
                   {
                        Console.WriteLine($"   > {id} > {value}{unit} [{value:X4}h]");
                   }
                   else if (value is int)
                   {
                       Console.WriteLine($"   > {id} > {value} {unit} [{value:X4}h]");
                   }
                   else if (value is uint)
                   {
                       Console.WriteLine($"   > {id} > {value} {unit} [{value:X4}h]");
                   }
                   else if (value is long)
                   {
                       Console.WriteLine($"   > {id} > {value} {unit} [{value:X8}h]");
                   }
                   else if (value is ulong)
                   {
                       Console.WriteLine($"   > {id} > {value} {unit} [{value:X8}h]");
                   }
                   else if (value.GetType() == typeof(ReadOnlyCollection<byte>))
                   {
                       Console.WriteLine($"   > {id} > {string.Join(", ", (ReadOnlyCollection<byte>)value)}");
                   }
                   else if (value.GetType() == typeof(ReadOnlyCollection<string>))
                   {
                       Console.WriteLine($"   > {id}");
                       var collection = (ReadOnlyCollection<string>) value;
                       foreach (var entry in collection)
                       {
                           Console.WriteLine($"     > {entry} {unit}");
                       }
                   }
                   else
                   {
                       Console.WriteLine($"   > {id} > {value} {unit}");
                   }
               }
           }
       }

# How can I send feedback!!!

If you have found **iSMBIOS** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iSMBIOS**, please send me and email stating why this is so. I will use this feedback to improve **iSMBIOS** in future releases.

My email address is fdo.garcia.vega@gmail.com
