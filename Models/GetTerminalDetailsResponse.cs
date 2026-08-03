using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record GetTerminalDetailsResponse
{
    /// <summary>
    /// The Bluetooth IP address of the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bluetoothIp")]
    public string? BluetoothIp { get; init; }

    /// <summary>
    /// The Bluetooth MAC address of the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bluetoothMac")]
    public string? BluetoothMac { get; init; }

    /// <summary>
    /// The company account that the terminal is associated with. If this is the only account level shown in the response, the terminal is assigned to the inventory of the company account.
    /// </summary>
    [JsonPropertyName("companyAccount")]
    public required string CompanyAccount { get; init; }

    /// <summary>
    /// The country where the terminal is used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// The model name of the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceModel")]
    public string? DeviceModel { get; init; }

    /// <summary>
    /// Indicates whether assigning IP addresses through a DHCP server is enabled on the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dhcpEnabled")]
    public bool? DhcpEnabled { get; init; }

    /// <summary>
    /// The label shown on the status bar of the display. This label (if any) is specified in your Customer Area.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayLabel")]
    public string? DisplayLabel { get; init; }

    /// <summary>
    /// The terminal's IP address in your Ethernet network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ethernetIp")]
    public string? EthernetIp { get; init; }

    /// <summary>
    /// The terminal's MAC address in your Ethernet network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ethernetMac")]
    public string? EthernetMac { get; init; }

    /// <summary>
    /// The software release currently in use on the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firmwareVersion")]
    public string? FirmwareVersion { get; init; }

    /// <summary>
    /// The integrated circuit card identifier (ICCID) of the SIM card in the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iccid")]
    public string? Iccid { get; init; }

    /// <summary>
    /// Date and time of the last activity on the terminal. Not included when the last activity was more than 14 days ago.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastActivityDateTime")]
    public DateTimeOffset? LastActivityDateTime { get; init; }

    /// <summary>
    /// Date and time of the last transaction on the terminal. Not included when the last transaction was more than 14 days ago.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastTransactionDateTime")]
    public DateTimeOffset? LastTransactionDateTime { get; init; }

    /// <summary>
    /// The Ethernet link negotiation that the terminal uses:
    /// <list type="bullet">
    ///   <item><description><c>auto</c>: Auto-negotiation</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>100full</c>: 100 Mbps full duplex</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("linkNegotiation")]
    public string? LinkNegotiation { get; init; }

    /// <summary>
    /// The merchant account that the terminal is associated with. If the response doesn't contain a <c>store</c> the terminal is assigned to this merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccount")]
    public string? MerchantAccount { get; init; }

    /// <summary>
    /// Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.
    /// <list type="bullet">
    ///   <item><description>If <b>true</b>, this indicates that the terminal is in the merchant inventory. This also means that the terminal cannot be boarded.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>If <b>false</b>, this indicates that the terminal is assigned to the merchant account as an in-store terminal. This means that the terminal is ready to be boarded, or is already boarded.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantInventory")]
    public bool? MerchantInventory { get; init; }

    /// <summary>
    /// The permanent terminal ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("permanentTerminalId")]
    public string? PermanentTerminalId { get; init; }

    /// <summary>
    /// The serial number of the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; init; }

    /// <summary>
    /// On a terminal that supports 3G or 4G connectivity, indicates the status of the SIM card in the terminal: ACTIVE or INVENTORY.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("simStatus")]
    public string? SimStatus { get; init; }

    /// <summary>
    /// The store code of the store that the terminal is assigned to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeDetails")]
    public Store1? StoreDetails { get; init; }

    /// <summary>
    /// The unique terminal ID.
    /// </summary>
    [JsonPropertyName("terminal")]
    public required string Terminal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalStatus")]
    public TerminalStatus? TerminalStatus { get; init; }

    /// <summary>
    /// The terminal's IP address in your Wi-Fi network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wifiIp")]
    public string? WifiIp { get; init; }

    /// <summary>
    /// The terminal's MAC address in your Wi-Fi network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wifiMac")]
    public string? WifiMac { get; init; }
}
