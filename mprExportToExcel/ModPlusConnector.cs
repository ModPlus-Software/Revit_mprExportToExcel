namespace mprExportToExcel;

using System;
using System.Collections.Generic;
using ModPlusAPI.Abstractions;
using ModPlusAPI.Enums;

/// <inheritdoc/>
public class ModPlusConnector : IModPlusPlugin
{
    private static ModPlusConnector _instance;

    /// <summary>
    /// Singleton instance
    /// </summary>
    public static ModPlusConnector Instance => _instance ??= new ModPlusConnector();

    /// <inheritdoc/>
    public SupportedProduct SupportedProduct => SupportedProduct.Revit;

    /// <inheritdoc/>
    public string Name => nameof(mprExportToExcel);

#if R2017
    /// <inheritdoc/>
    public string AvailProductExternalVersion => "2017";
#elif R2018
    /// <inheritdoc/>
    public string AvailProductExternalVersion => "2018";
#elif R2019
    /// <inheritdoc/>
    public string AvailProductExternalVersion => "2019";
#elif R2020
    /// <inheritdoc/>
    public string AvailProductExternalVersion => "2020";
#elif R2021
    /// <inheritdoc/>
    public string AvailProductExternalVersion => "2021";
#elif R2022
    /// <inheritdoc/>
    public string AvailProductExternalVersion => "2022";
#elif R2023
    /// <inheritdoc/>
    public string AvailProductExternalVersion => "2023";
#endif

    /// <inheritdoc/>
    public string FullClassName => $"{nameof(mprExportToExcel)}.{nameof(Command)}";

    /// <inheritdoc/>
    public string AppFullClassName => string.Empty;

    /// <inheritdoc/>
    public Guid AddInId => Guid.Empty;
    
    /// <inheritdoc/>
    public string Price => "0";

    /// <inheritdoc/>
    public bool CanAddToRibbon => true;
    
    /// <inheritdoc/>
    public string ToolTipHelpImage => string.Empty;

    /// <inheritdoc/>
    public List<string> SubPluginsNames => new ();
    
    /// <inheritdoc/>
    public List<string> SubHelpImages => new ();

    /// <inheritdoc/>
    public List<string> SubClassNames => new ();
}