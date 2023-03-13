﻿namespace flic2lib.Maui;

public partial class FlicManager
{
    private readonly IList<FlicButton> _cachedButtons;

    public static bool IsInitialized { get; private set; }
    public static FlicManager Instance { get; } = new FlicManager();
    public IEnumerable<FlicButton>? Buttons => GetButtons();

    private FlicManager() 
    {
        _cachedButtons = new List<FlicButton>();
    }

    public static partial void Init();
    public partial void StartScan();
    public partial void StopScan();
    public partial FlicButton? GetButtonByUuid(string? uuid);
    public partial void ForgetButton(FlicButton button);
    private partial IEnumerable<FlicButton>? GetButtons();
}

public enum FlicScanResult
{
    SCAN_RESULT_SUCCESS = 0,
    SCAN_RESULT_ERROR_ALREADY_RUNNING = 1,
    SCAN_RESULT_ERROR_BLUETOOTH_NOT_ACTIVATED = 2,
    SCAN_RESULT_ERROR_UNKNOWN = 3,
    SCAN_RESULT_ERROR_NO_PUBLIC_BUTTON_DISCOVERED = 4,
    SCAN_RESULT_ERROR_ALREADY_CONNECTED_TO_ANOTHER_DEVICE = 5,
    SCAN_RESULT_ERROR_CONNECTION_TIMEOUT = 6,
    SCAN_RESULT_ERROR_INVALID_VERIFIER = 7,
    SCAN_RESULT_ERROR_BLE_PAIRING_FAILED_PREVIOUS_PAIRING_ALREADY_EXISTING = 8,
    SCAN_RESULT_ERROR_BLE_PAIRING_FAILED_USER_CANCELED = 9,
    SCAN_RESULT_ERROR_BLE_PAIRING_FAILED_UNKNOWN_REASON = 10,
    SCAN_RESULT_ERROR_APP_CREDENTIALS_DONT_MATCH = 11,
    SCAN_RESULT_ERROR_USER_CANCELED = 12,
    SCAN_RESULT_ERROR_INVALID_BLUETOOTH_ADDRESS = 13,
    SCAN_RESULT_ERROR_GENUINE_CHECK_FAILED = 14,
    SCAN_RESULT_ERROR_TOO_MANY_APPS = 15,
    SCAN_RESULT_ERROR_COULD_NOT_SET_BLUETOOTH_NOTIFY = 16,
    SCAN_RESULT_ERROR_COULD_NOT_DISCOVER_BLUETOOTH_SERVICES = 17,
    SCAN_RESULT_ERROR_BUTTON_DISCONNECTED_DURING_VERIFICATION = 18,
    SCAN_RESULT_ERROR_FAILED_TO_ESTABLISH = 19,
    SCAN_RESULT_ERROR_CONNECTION_LIMIT_REACHED = 20,
    SCAN_RESULT_ERROR_NOT_IN_PUBLIC_MODE = 21,
}