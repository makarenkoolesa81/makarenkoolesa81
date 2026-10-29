using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

[Serializable]
public class _0x591c96c0
{
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string meta = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string payload = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string isMeta = "";
}

public class _0x9cbda3d8 : MonoBehaviour
{
    readonly System.Random _0x57340fec = new System.Random();
    private async Task<bool> _0x87f5089e()
    {
        {
#if B_LOGS
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[37] { 153, 150, 167, 177, 182, 159, 226, 145, 171, 165, 172, 139, 172, 151, 172, 171, 182, 187, 145, 167, 176, 180, 171, 161, 167, 177, 131, 172, 173, 172, 187, 175, 173, 183, 177, 174, 187 }, 194));
#endif
        }

        try
        {
            var _0xa6084eaf = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xa6084eaf);
            {
#if B_LOGS
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[32] { 116, 123, 74, 92, 91, 114, 15, 122, 65, 70, 91, 86, 124, 74, 93, 89, 70, 76, 74, 92, 15, 102, 65, 70, 91, 70, 78, 67, 70, 85, 74, 75 }, 47));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[20] { 15, 30, 8, 15, 123, 14, 53, 50, 47, 34, 8, 62, 41, 45, 50, 56, 62, 40, 97, 123 }, 91) + ex.Message);
#endif
            }

            _0x737a8a6e?._0xc2c27d41();
            return true;
        }

        bool _0xd87360a0 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xd87360a0 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[37] { 83, 92, 109, 123, 124, 85, 40, 91, 97, 111, 102, 37, 97, 102, 40, 73, 102, 103, 102, 113, 101, 103, 125, 123, 38, 40, 88, 100, 105, 113, 109, 122, 40, 65, 76, 50, 40 }, 8) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xf05bb907 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[25] { 231, 246, 224, 231, 147, 224, 218, 212, 221, 158, 218, 221, 147, 242, 198, 199, 219, 147, 246, 225, 225, 252, 225, 137, 147 }, 179) + ex.Message);
#endif
                }

                _0x737a8a6e?._0xc2c27d41();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[28] { 141, 156, 138, 141, 249, 138, 176, 190, 183, 244, 176, 183, 249, 139, 188, 168, 172, 188, 170, 173, 249, 156, 139, 139, 150, 139, 227, 249 }, 217) + ex.Message);
#endif
                }

                _0x737a8a6e?._0xc2c27d41();
                return true;
            }
        }
        while (!_0xd87360a0);
        return false;
    }

    private bool _0xc107eaa8()
    {
        _0xe8809626.RemoveAll(_0xcd0830ff => _0xcd0830ff == null || !_0xcd0830ff.IsAlive);
        return _0xe8809626.Count > 0;
    }

    internal bool isApplicationFocus = false;
    private bool _0x7e692210(string _0xd2d1551e)
    {
        try
        {
            using (var _0x44c3b25b = new AndroidJavaClass(_0x25b7f0af._0x6b6dc4b7(new byte[30] { 123, 119, 117, 54, 109, 118, 113, 108, 97, 43, 124, 54, 104, 116, 121, 97, 125, 106, 54, 77, 118, 113, 108, 97, 72, 116, 121, 97, 125, 106 }, 24)))
            using (var _0x444f29c1 = _0x44c3b25b.GetStatic<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[15] { 169, 191, 184, 184, 175, 164, 190, 139, 169, 190, 163, 188, 163, 190, 179 }, 202)))
            using (var _0x64d10a02 = _0x444f29c1.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[17] { 45, 47, 62, 26, 43, 41, 33, 43, 45, 47, 7, 43, 36, 43, 45, 47, 56 }, 74)))
            using (var _0x9336e973 = new AndroidJavaClass(_0x25b7f0af._0x6b6dc4b7(new byte[22] { 217, 214, 220, 202, 215, 209, 220, 150, 219, 215, 214, 204, 221, 214, 204, 150, 241, 214, 204, 221, 214, 204 }, 184)))
            using (var _0x6922b09d = _0x9336e973.CallStatic<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[8] { 216, 201, 218, 219, 205, 253, 218, 193 }, 168), _0xd2d1551e, 1))
            {
                string _0x15d88b8f = _0x6922b09d.Call<string>(_0x25b7f0af._0x6b6dc4b7(new byte[14] { 47, 45, 60, 27, 60, 58, 33, 38, 47, 13, 48, 60, 58, 41 }, 72), _0x25b7f0af._0x6b6dc4b7(new byte[20] { 15, 31, 2, 26, 30, 8, 31, 50, 11, 12, 1, 1, 15, 12, 14, 6, 50, 24, 31, 1 }, 109));
                string _0x065b0964 = _0x6922b09d.Call<string>(_0x25b7f0af._0x6b6dc4b7(new byte[10] { 62, 60, 45, 9, 56, 58, 50, 56, 62, 60 }, 89));
                _0x6922b09d.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[11] { 245, 240, 240, 215, 245, 224, 241, 243, 251, 230, 237 }, 148), _0x25b7f0af._0x6b6dc4b7(new byte[33] { 61, 50, 56, 46, 51, 53, 56, 114, 53, 50, 40, 57, 50, 40, 114, 63, 61, 40, 57, 59, 51, 46, 37, 114, 30, 14, 19, 11, 15, 29, 30, 16, 25 }, 92));
                _0x6922b09d.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[11] { 83, 68, 76, 78, 87, 68, 100, 89, 85, 83, 64 }, 33), _0x25b7f0af._0x6b6dc4b7(new byte[20] { 237, 253, 224, 248, 252, 234, 253, 208, 233, 238, 227, 227, 237, 238, 236, 228, 208, 250, 253, 227 }, 143));
                if (_0x6922b09d.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[15] { 22, 1, 23, 11, 8, 18, 1, 37, 7, 16, 13, 18, 13, 16, 29 }, 100), _0x64d10a02) != null)
                {
                    WLog(_0x25b7f0af._0x6b6dc4b7(new byte[24] { 51, 24, 2, 31, 29, 21, 60, 25, 27, 21, 80, 31, 0, 21, 30, 80, 25, 30, 4, 21, 30, 4, 74, 80 }, 112) + _0xd2d1551e);
                    _0x6922b09d.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[8] { 237, 232, 232, 202, 224, 237, 235, 255 }, 140), 0x10000000);
                    _0x444f29c1.Call(_0x25b7f0af._0x6b6dc4b7(new byte[13] { 25, 30, 11, 24, 30, 43, 9, 30, 3, 28, 3, 30, 19 }, 106), _0x6922b09d);
                    return true;
                }

                if (_0x73a72086(_0x065b0964))
                    return true;
                if (!string.IsNullOrEmpty(_0x15d88b8f))
                {
                    WLog(_0x25b7f0af._0x6b6dc4b7(new byte[28] { 47, 4, 30, 3, 1, 9, 32, 5, 7, 9, 76, 5, 2, 24, 9, 2, 24, 76, 10, 13, 0, 0, 14, 13, 15, 7, 86, 76 }, 108) + _0x15d88b8f);
                    if (_0xd26de3b2(_0x15d88b8f))
                        return _0xd3419975(_0x15d88b8f, _0x065b0964);
                    return _0x82385490(_0x15d88b8f);
                }

                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[30] { 166, 141, 151, 138, 136, 128, 169, 140, 142, 128, 197, 140, 139, 145, 128, 139, 145, 197, 139, 138, 197, 141, 132, 139, 129, 137, 128, 151, 223, 197 }, 229) + _0xd2d1551e);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[26] { 18, 57, 35, 62, 60, 52, 29, 56, 58, 52, 113, 56, 63, 37, 52, 63, 37, 113, 55, 48, 56, 61, 52, 53, 107, 113 }, 81) + e.Message);
            return true;
        }
    }

    internal void Update()
    {
        if (_0xe655ee78 == null)
            return;
        if (_0x6cb044f8())
            _0x975f1c0f();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xf50d963f();
        if (_0xc11ff0a2 && _0x7e00ecde != null)
            _0x7e00ecde.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private Text _0x9294a456;
    private string _0xbff068ef = "";
    private string _0xbf684d9d()
    {
        string _0xb62937f2 = _0x5fda691d();
        if (string.IsNullOrEmpty(_0xb62937f2))
            return _0x25b7f0af._0x6b6dc4b7(new byte[7] { 69, 92, 90, 87, 19, 3, 8 }, 51);
        string _0xf8d10e33 = _0xb62937f2.Replace(_0x25b7f0af._0x6b6dc4b7(new byte[1] { 214 }, 138), _0x25b7f0af._0x6b6dc4b7(new byte[2] { 246, 246 }, 170)).Replace(_0x25b7f0af._0x6b6dc4b7(new byte[1] { 141 }, 170), _0x25b7f0af._0x6b6dc4b7(new byte[2] { 229, 158 }, 185));
        var _0xbd6ac7ce = Regex.Match(_0xb62937f2, _0x25b7f0af._0x6b6dc4b7(new byte[12] { 0, 43, 49, 44, 46, 38, 108, 107, 31, 39, 104, 106 }, 67));
        string _0xe203bf38 = _0xbd6ac7ce.Success ? _0xbd6ac7ce.Groups[1].Value : _0x25b7f0af._0x6b6dc4b7(new byte[3] { 85, 86, 84 }, 100);
        return _0x25b7f0af._0x6b6dc4b7(new byte[12] { 208, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131 }, 248) + _0x25b7f0af._0x6b6dc4b7(new byte[8] { 132, 147, 128, 210, 135, 147, 207, 213 }, 242) + _0xf8d10e33 + _0x25b7f0af._0x6b6dc4b7(new byte[2] { 49, 45 }, 22) + _0x25b7f0af._0x6b6dc4b7(new byte[30] { 88, 79, 92, 14, 94, 92, 65, 90, 65, 19, 96, 79, 88, 71, 73, 79, 90, 65, 92, 0, 94, 92, 65, 90, 65, 90, 87, 94, 75, 21 }, 46) + _0x25b7f0af._0x6b6dc4b7(new byte[121] { 251, 232, 243, 254, 233, 244, 242, 243, 189, 249, 248, 251, 181, 242, 255, 247, 177, 246, 248, 228, 177, 235, 252, 241, 180, 230, 233, 239, 228, 230, 210, 255, 247, 248, 254, 233, 179, 249, 248, 251, 244, 243, 248, 205, 239, 242, 237, 248, 239, 233, 228, 181, 242, 255, 247, 177, 246, 248, 228, 177, 230, 250, 248, 233, 167, 251, 232, 243, 254, 233, 244, 242, 243, 181, 180, 230, 239, 248, 233, 232, 239, 243, 189, 235, 252, 241, 166, 224, 177, 254, 242, 243, 251, 244, 250, 232, 239, 252, 255, 241, 248, 167, 233, 239, 232, 248, 224, 180, 166, 224, 254, 252, 233, 254, 245, 181, 248, 180, 230, 224, 224 }, 157) + _0x25b7f0af._0x6b6dc4b7(new byte[26] { 177, 176, 179, 253, 165, 167, 186, 161, 186, 249, 242, 160, 166, 176, 167, 148, 178, 176, 187, 161, 242, 249, 160, 180, 252, 238 }, 213) + _0x25b7f0af._0x6b6dc4b7(new byte[52] { 45, 44, 47, 97, 57, 59, 38, 61, 38, 101, 110, 40, 57, 57, 31, 44, 59, 58, 32, 38, 39, 110, 101, 60, 40, 103, 59, 44, 57, 37, 40, 42, 44, 97, 102, 23, 4, 38, 51, 32, 37, 37, 40, 21, 102, 102, 101, 110, 110, 96, 96, 114 }, 73) + _0x25b7f0af._0x6b6dc4b7(new byte[37] { 201, 200, 203, 133, 221, 223, 194, 217, 194, 129, 138, 221, 193, 204, 217, 203, 194, 223, 192, 138, 129, 138, 225, 196, 195, 216, 213, 141, 204, 223, 192, 219, 149, 193, 138, 132, 150 }, 173) + _0x25b7f0af._0x6b6dc4b7(new byte[34] { 250, 251, 248, 182, 238, 236, 241, 234, 241, 178, 185, 232, 251, 240, 250, 241, 236, 185, 178, 185, 217, 241, 241, 249, 242, 251, 190, 215, 240, 253, 176, 185, 183, 165 }, 158) + _0x25b7f0af._0x6b6dc4b7(new byte[30] { 52, 53, 54, 120, 32, 34, 63, 36, 63, 124, 119, 61, 49, 40, 4, 63, 37, 51, 56, 0, 63, 57, 62, 36, 35, 119, 124, 101, 121, 107 }, 80) + _0x25b7f0af._0x6b6dc4b7(new byte[48] { 242, 244, 255, 253, 240, 231, 244, 166, 243, 231, 226, 187, 253, 228, 244, 231, 232, 226, 245, 188, 221, 253, 228, 244, 231, 232, 226, 188, 161, 197, 238, 244, 233, 235, 239, 243, 235, 161, 170, 240, 227, 244, 245, 239, 233, 232, 188, 161 }, 134) + _0xe203bf38 + _0x25b7f0af._0x6b6dc4b7(new byte[35] { 176, 234, 187, 236, 245, 229, 246, 249, 243, 173, 176, 208, 248, 248, 240, 251, 242, 183, 212, 255, 229, 248, 250, 242, 176, 187, 225, 242, 229, 228, 254, 248, 249, 173, 176 }, 151) + _0xe203bf38 + _0x25b7f0af._0x6b6dc4b7(new byte[238] { 231, 189, 236, 187, 162, 178, 161, 174, 164, 250, 231, 142, 175, 180, 253, 129, 255, 130, 178, 161, 174, 164, 231, 236, 182, 165, 178, 179, 169, 175, 174, 250, 231, 242, 244, 231, 189, 157, 236, 173, 175, 162, 169, 172, 165, 250, 180, 178, 181, 165, 236, 176, 172, 161, 180, 166, 175, 178, 173, 250, 231, 129, 174, 164, 178, 175, 169, 164, 231, 236, 167, 165, 180, 136, 169, 167, 168, 133, 174, 180, 178, 175, 176, 185, 150, 161, 172, 181, 165, 179, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 178, 165, 180, 181, 178, 174, 224, 144, 178, 175, 173, 169, 179, 165, 238, 178, 165, 179, 175, 172, 182, 165, 232, 187, 161, 178, 163, 168, 169, 180, 165, 163, 180, 181, 178, 165, 250, 231, 161, 178, 173, 231, 236, 162, 169, 180, 174, 165, 179, 179, 250, 231, 246, 244, 231, 236, 173, 175, 162, 169, 172, 165, 250, 180, 178, 181, 165, 236, 173, 175, 164, 165, 172, 250, 231, 231, 236, 176, 172, 161, 180, 166, 175, 178, 173, 250, 231, 129, 174, 164, 178, 175, 169, 164, 231, 236, 176, 172, 161, 180, 166, 175, 178, 173, 150, 165, 178, 179, 169, 175, 174, 250, 231, 241, 244, 238, 240, 238, 240, 231, 236, 181, 161, 134, 181, 172, 172, 150, 165, 178, 179, 169, 175, 174, 250, 231 }, 192) + _0xe203bf38 + _0x25b7f0af._0x6b6dc4b7(new byte[117] { 235, 245, 235, 245, 235, 245, 226, 184, 236, 254, 184, 184, 254, 138, 167, 175, 160, 166, 177, 235, 161, 160, 163, 172, 171, 160, 149, 183, 170, 181, 160, 183, 177, 188, 237, 181, 183, 170, 177, 170, 233, 226, 176, 182, 160, 183, 132, 162, 160, 171, 177, 129, 164, 177, 164, 226, 233, 190, 162, 160, 177, 255, 163, 176, 171, 166, 177, 172, 170, 171, 237, 236, 190, 183, 160, 177, 176, 183, 171, 229, 176, 164, 161, 254, 184, 233, 166, 170, 171, 163, 172, 162, 176, 183, 164, 167, 169, 160, 255, 177, 183, 176, 160, 184, 236, 254, 184, 166, 164, 177, 166, 173, 237, 160, 236, 190, 184 }, 197) + _0x25b7f0af._0x6b6dc4b7(new byte[5] { 151, 195, 194, 195, 209 }, 234);
    }

    internal bool _0xd26de3b2(string _0x1b40b5f8)
    {
        return _0x1b40b5f8.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[9] { 0, 12, 31, 6, 8, 25, 87, 66, 66 }, 109), StringComparison.OrdinalIgnoreCase) || _0x1b40b5f8.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[24] { 225, 253, 253, 249, 250, 179, 166, 166, 249, 229, 232, 240, 167, 238, 230, 230, 238, 229, 236, 167, 234, 230, 228, 166 }, 137), StringComparison.OrdinalIgnoreCase) || _0x1b40b5f8.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[23] { 2, 30, 30, 26, 80, 69, 69, 26, 6, 11, 19, 68, 13, 5, 5, 13, 6, 15, 68, 9, 5, 7, 69 }, 106), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x5fda691d()
    {
        if (string.IsNullOrEmpty(_0xf8665526) && _0xe655ee78 != null)
            _0xf8665526 = _0xe655ee78.GetUserAgent();
        if (string.IsNullOrEmpty(_0xf8665526))
            return string.Empty;
        string _0x9a39db9d = Regex.Replace(_0xf8665526, _0x25b7f0af._0x6b6dc4b7(new byte[11] { 121, 86, 15, 30, 121, 86, 15, 82, 83, 121, 71 }, 37), string.Empty);
        _0x9a39db9d = Regex.Replace(_0x9a39db9d, _0x25b7f0af._0x6b6dc4b7(new byte[15] { 199, 232, 176, 217, 238, 242, 247, 255, 180, 192, 197, 160, 178, 198, 176 }, 155), string.Empty);
        _0x9a39db9d = Regex.Replace(_0x9a39db9d, _0x25b7f0af._0x6b6dc4b7(new byte[15] { 30, 45, 58, 59, 33, 39, 38, 103, 124, 20, 102, 120, 20, 59, 98 }, 72), string.Empty);
        return Regex.Replace(_0x9a39db9d, _0x25b7f0af._0x6b6dc4b7(new byte[6] { 195, 236, 228, 173, 179, 226 }, 159), _0x25b7f0af._0x6b6dc4b7(new byte[1] { 100 }, 68)).Trim();
    }

    static byte[] ToBigEndian(System.Numerics.BigInteger _0xe63a0edf)
    {
        var _0x4f412cb0 = _0xe63a0edf.ToByteArray();
        int _0xe36bdea7 = _0x4f412cb0.Length;
        if (_0xe36bdea7 > 1 && _0x4f412cb0[_0xe36bdea7 - 1] == 0)
            _0xe36bdea7--;
        var _0x448bf30e = new byte[_0xe36bdea7];
        for (int _0x776a90c3 = 0; _0x776a90c3 < _0xe36bdea7; _0x776a90c3++)
            _0x448bf30e[_0x776a90c3] = _0x4f412cb0[_0xe36bdea7 - 1 - _0x776a90c3];
        return _0x448bf30e;
    }

    private bool _0x6849883f = false;
    private void _0xabfd088f(bool _0x4c25b58a)
    {
        _0xd2b91db5();
        _0x805495c8.SetActive(_0x4c25b58a);
        _0xc11ff0a2 = _0x4c25b58a;
        if (_0x4c25b58a)
        {
            _0x805495c8.transform.SetAsLastSibling();
            if (_0x7e00ecde != null)
                _0x7e00ecde.localRotation = Quaternion.identity;
        }
    }

    static byte[] PackSmallest(byte[] _0x5c8353fe, out byte _0x33553bc7)
    {
        var _0xf2fa0d45 = CompressBrotli(_0x5c8353fe);
        var _0xefd1249c = CompressDeflate(_0x5c8353fe);
        if (_0xf2fa0d45.Length < _0x5c8353fe.Length && _0xf2fa0d45.Length <= _0xefd1249c.Length)
        {
            _0x33553bc7 = 1;
            return _0xf2fa0d45;
        }

        if (_0xefd1249c.Length < _0x5c8353fe.Length)
        {
            _0x33553bc7 = 2;
            return _0xefd1249c;
        }

        _0x33553bc7 = 0;
        return _0x5c8353fe;
    }

    static System.Numerics.BigInteger FromBigEndian(byte[] _0xb16a7313)
    {
        var _0x661dfd08 = new byte[_0xb16a7313.Length + 1];
        for (int _0x76a77748 = 0; _0x76a77748 < _0xb16a7313.Length; _0x76a77748++)
            _0x661dfd08[_0xb16a7313.Length - 1 - _0x76a77748] = _0xb16a7313[_0x76a77748];
        return new System.Numerics.BigInteger(_0x661dfd08);
    }

    private string _0xcb7d8c73 = "";
    private void OnApplicationFocus(bool _0xf0be22d2)
    {
        isApplicationFocus = _0xf0be22d2;
        if (_0xf0be22d2 && _0x01e632f1)
        {
            _0x17e2785c();
        }
    }

    private void _0xd2b91db5()
    {
        if (_0x805495c8 != null)
            return;
        var _0x130acd65 = _0xe04d48fc();
        _0x805495c8 = new GameObject(_0x25b7f0af._0x6b6dc4b7(new byte[14] { 15, 61, 58, 14, 49, 61, 47, 11, 40, 49, 54, 54, 61, 42 }, 88), typeof(RectTransform), typeof(Text));
        _0x7e00ecde = _0x805495c8.GetComponent<RectTransform>();
        _0x7e00ecde.SetParent(_0x130acd65.transform, false);
        _0x7e00ecde.anchorMin = new Vector2(0.5f, 0.5f);
        _0x7e00ecde.anchorMax = new Vector2(0.5f, 0.5f);
        _0x7e00ecde.pivot = new Vector2(0.5f, 0.5f);
        _0x7e00ecde.sizeDelta = new Vector2(600f, 600f);
        _0x7e00ecde.anchoredPosition = Vector2.zero;
        _0x9294a456 = _0x805495c8.GetComponent<Text>();
        _0x9294a456.text = _0x25b7f0af._0x6b6dc4b7(new byte[1] { 237 }, 194);
        _0x9294a456.font = Resources.GetBuiltinResource<Font>(_0x25b7f0af._0x6b6dc4b7(new byte[17] { 56, 17, 19, 21, 23, 13, 38, 1, 26, 0, 29, 25, 17, 90, 0, 0, 18 }, 116));
        _0x9294a456.fontSize = 200;
        _0x9294a456.alignment = TextAnchor.MiddleCenter;
        _0x9294a456.color = Color.white;
        _0x9294a456.raycastTarget = false;
        _0x805495c8.SetActive(false);
    }

    private void _0x521cdd15(string _0x9b03761a)
    {
        if (string.IsNullOrEmpty(_0x9b03761a))
            return;
        if (TryOpenExternalLikeChrome(_0x9b03761a))
            return;
        OpenUrlExternally(_0x9b03761a);
    }

    private void WLog(string _0x02bf0085)
    {
#if B_LOGS
        {
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[7] { 238, 225, 208, 198, 193, 232, 149 }, 181) + _0x02bf0085);
        }
#endif
    }

    internal bool IsAboutBlank(string _0x99746145)
    {
        if (string.IsNullOrEmpty(_0x99746145))
            return false;
        return _0x99746145.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[11] { 224, 227, 238, 244, 245, 187, 227, 237, 224, 239, 234 }, 129), StringComparison.OrdinalIgnoreCase);
    }

    // WEB VIEW LOGIC END
    internal void _0xd548933d()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x58a1fae4 = new AndroidNotificationChannel
        {
            Id = _0x25b7f0af._0x6b6dc4b7(new byte[15] { 52, 53, 54, 49, 37, 60, 36, 15, 51, 56, 49, 62, 62, 53, 60 }, 80),
            Name = _0x25b7f0af._0x6b6dc4b7(new byte[15] { 41, 8, 11, 12, 24, 1, 25, 77, 46, 5, 12, 3, 3, 8, 1 }, 109),
            Importance = Importance.High,
            Description = _0x25b7f0af._0x6b6dc4b7(new byte[21] { 103, 69, 78, 69, 82, 65, 76, 0, 78, 79, 84, 73, 70, 73, 67, 65, 84, 73, 79, 78, 83 }, 32)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x58a1fae4);
        // Build notification
        var _0xbde3bf9b = new AndroidNotification
        {
            Title = _0x9329fbbf[UnityEngine.Random.Range(0, _0x9329fbbf.Length)],
            Text = _0x25b7f0af._0x6b6dc4b7(new byte[21] { 209, 226, 245, 176, 233, 255, 229, 176, 227, 229, 226, 245, 176, 228, 255, 176, 245, 232, 249, 228, 175 }, 144),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xbde3bf9b, _0x25b7f0af._0x6b6dc4b7(new byte[15] { 18, 19, 16, 23, 3, 26, 2, 41, 21, 30, 23, 24, 24, 19, 26 }, 118));
    }

    private IEnumerator _0xb23b855d(IEnumerator _0xa60f946a, TaskCompletionSource<bool> _0xbc099c71)
    {
        yield return _0xa60f946a;
        _0xbc099c71.SetResult(true);
    }

    static byte[] Decode93(string _0xfbf5631a)
    {
        var _0xe1a06af2 = System.Numerics.BigInteger.Zero;
        var _0x259e099d = new System.Numerics.BigInteger(TextAlphabet.Length);
        for (int _0xea5b2903 = 0; _0xea5b2903 < _0xfbf5631a.Length; _0xea5b2903++)
        {
            char _0x46e5b88c = _0xfbf5631a[_0xea5b2903];
            if (_0x46e5b88c >= _0xea639203.Length)
                throw new FormatException();
            int _0x5b358fe8 = _0xea639203[_0x46e5b88c];
            if (_0x5b358fe8 < 0)
                throw new FormatException();
            _0xe1a06af2 = _0xe1a06af2 * _0x259e099d + _0x5b358fe8;
        }

        var _0xa5c38520 = ToBigEndian(_0xe1a06af2);
        if (_0xa5c38520.Length < 2 || _0xa5c38520[0] != 1)
            throw new FormatException();
        var _0xba257f1e = new byte[_0xa5c38520.Length - 1];
        Buffer.BlockCopy(_0xa5c38520, 1, _0xba257f1e, 0, _0xba257f1e.Length);
        return _0xba257f1e;
    }

    private string _0x01d571af()
    {
        try
        {
            using (var _0x9a705b18 = new AndroidJavaClass(_0x25b7f0af._0x6b6dc4b7(new byte[30] { 38, 42, 40, 107, 48, 43, 44, 49, 60, 118, 33, 107, 53, 41, 36, 60, 32, 55, 107, 16, 43, 44, 49, 60, 21, 41, 36, 60, 32, 55 }, 69)))
            {
                var _0x57da856c = _0x9a705b18.GetStatic<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[15] { 44, 58, 61, 61, 42, 33, 59, 14, 44, 59, 38, 57, 38, 59, 54 }, 79));
                var _0x596cafda = _0x57da856c.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[21] { 30, 28, 13, 56, 9, 9, 21, 16, 26, 24, 13, 16, 22, 23, 58, 22, 23, 13, 28, 1, 13 }, 121));
                using (var _0x070b094d = new AndroidJavaClass(_0x25b7f0af._0x6b6dc4b7(new byte[26] { 37, 42, 32, 54, 43, 45, 32, 106, 51, 33, 38, 47, 45, 48, 106, 19, 33, 38, 23, 33, 48, 48, 45, 42, 35, 55 }, 68)))
                {
                    return _0x070b094d.CallStatic<string>(_0x25b7f0af._0x6b6dc4b7(new byte[19] { 0, 2, 19, 35, 2, 1, 6, 18, 11, 19, 50, 20, 2, 21, 38, 0, 2, 9, 19 }, 103), _0x596cafda);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    readonly struct CommState
    {
        public readonly bool Ready;
        public readonly bool IsPrivacy;
        public readonly string SavedLink;
        public CommState(bool _0x268f1989, bool _0x424208c8, string _0x221ef6d6)
        {
            Ready = _0x268f1989;
            IsPrivacy = _0x424208c8;
            SavedLink = _0x221ef6d6 ?? "";
        }
    }

    static int[] BuildTextAlphabetIndex()
    {
        var _0x231e842d = new int[128];
        for (int _0x1ad456d8 = 0; _0x1ad456d8 < _0x231e842d.Length; _0x1ad456d8++)
            _0x231e842d[_0x1ad456d8] = -1;
        for (int _0x68c1923b = 0; _0x68c1923b < TextAlphabet.Length; _0x68c1923b++)
            _0x231e842d[TextAlphabet[_0x68c1923b]] = _0x68c1923b;
        return _0x231e842d;
    }

    private int _0xac7d9827 = 0;
    static readonly string LeaderboardId = _0x25b7f0af._0x6b6dc4b7(new byte[1] { 141 }, 189);
    private string _0x09d8212a = "";
    private bool _0x04c1460a()
    {
        var _0xad0588e4 = _0xe94a9051();
        if (_0xad0588e4 == null)
            return false;
        WLog(_0x25b7f0af._0x6b6dc4b7(new byte[31] { 3, 42, 57, 47, 60, 42, 57, 46, 107, 41, 42, 40, 32, 107, 102, 117, 107, 59, 36, 59, 62, 59, 107, 12, 36, 9, 42, 40, 32, 113, 107 }, 75) + _0xad0588e4.Id);
        _0xad0588e4.GoBack();
        return true;
    }

    private async Task _0x49278941(string _0xeaafcba2)
    {
        if (_0x6849883f || string.IsNullOrEmpty(_0xf05bb907) || string.IsNullOrEmpty(_0xeaafcba2) || _0x55a0ea70)
            return;
        _0x6849883f = true;
        try
        {
            JObject _0xd31ad015 = _0x4bdba1c7(_0xeaafcba2, _0xf05bb907, _0x4e99c389());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xeaafcba2} payload: {_0xd31ad015}");
                }
#endif
            }

            var _0x83243ef2 = _0x47c612b6(_0xd31ad015.ToString(), _0xf05bb907);
            await _0x2b4a38f4(LeaderboardId, 2d, _0x83243ef2);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[24] { 29, 18, 3, 21, 18, 27, 102, 10, 41, 39, 34, 102, 54, 39, 53, 53, 102, 35, 52, 52, 41, 52, 124, 102 }, 70) + e.Message);
#endif
            }
        }
    }

    private void Awake()
    {
        if (_0x737a8a6e != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x737a8a6e = gameObject.GetComponent<_0x9cbda3d8>();
        DontDestroyOnLoad(gameObject);
        _0x9d809bf8 = _0x7e6f24ee = _0x5ddebf5e = "";
        _0x8e9f3195 = "";
        _0x01e632f1 = false;
    }

    static byte[] CompressDeflate(byte[] _0x875967fc)
    {
        using var _0x90c74653 = new MemoryStream();
        using (var _0x847ad5cf = new DeflateStream(_0x90c74653, SmallestCompression()))
            _0x847ad5cf.Write(_0x875967fc, 0, _0x875967fc.Length);
        return _0x90c74653.ToArray();
    }

    private bool _0xb099d07c(int _0x043eab0b, string _0x3be944c0, string _0x565b4e98)
    {
        if (string.IsNullOrEmpty(_0x565b4e98))
            return false;
        if (!IsHttpUrl(_0x565b4e98))
            return true;
        if (string.IsNullOrEmpty(_0x3be944c0))
            return false;
        return _0x3be944c0.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[20] { 240, 231, 231, 234, 246, 250, 251, 251, 240, 246, 225, 252, 250, 251, 234, 231, 240, 230, 240, 225 }, 181), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3be944c0.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[22] { 148, 131, 131, 142, 146, 158, 159, 159, 148, 146, 133, 152, 158, 159, 142, 131, 148, 151, 132, 130, 148, 149 }, 209), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3be944c0.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[21] { 120, 111, 111, 98, 126, 114, 115, 115, 120, 126, 105, 116, 114, 115, 98, 126, 113, 114, 110, 120, 121 }, 61), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3be944c0.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[22] { 167, 176, 176, 189, 183, 172, 169, 172, 173, 181, 172, 189, 183, 176, 174, 189, 177, 161, 170, 167, 175, 167 }, 226), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    async Task<CommState> _0xb4aed4e4()
    {
        var _0xc6778216 = await LeaderboardsService.Instance.GetPlayerScoreAsync(LeaderboardId, new GetPlayerScoreOptions { IncludeMetadata = true });
        var _0x331b6da6 = ReadScoreMetadata(_0xc6778216 != null ? _0xc6778216.Metadata : null);
        if (string.IsNullOrEmpty(_0x331b6da6.isMeta))
            return default;
        var _0xef146e69 = _0x6fad998d(_0x331b6da6.isMeta, _0xf05bb907);
        if (_0xef146e69 != _0x25b7f0af._0x6b6dc4b7(new byte[4] { 167, 161, 166, 182 }, 211) && _0xef146e69 != _0x25b7f0af._0x6b6dc4b7(new byte[5] { 67, 68, 73, 86, 64 }, 37))
            return default;
        var _0x9ea89a14 = _0x6fad998d(_0x331b6da6.meta ?? "", _0xf05bb907);
        return new CommState(true, _0xef146e69 == _0x25b7f0af._0x6b6dc4b7(new byte[4] { 255, 249, 254, 238 }, 139), _0x9ea89a14);
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xc2c27d41();
    }

    async Task _0x2b4a38f4(string _0x533ea24a, double _0x66f6fcaa, string _0x90450a07)
    {
        var _0x0e3c2ae6 = new _0x591c96c0
        {
            payload = _0x90450a07 ?? ""
        };
        if (_0x66f6fcaa != 1d)
        {
            try
            {
                var _0xde06accf = await LeaderboardsService.Instance.GetPlayerScoreAsync(_0x533ea24a, new GetPlayerScoreOptions { IncludeMetadata = true });
                var _0xe5dea0df = ReadScoreMetadata(_0xde06accf != null ? _0xde06accf.Metadata : null);
                if (!string.IsNullOrEmpty(_0xe5dea0df.isMeta) || !string.IsNullOrEmpty(_0xe5dea0df.meta))
                {
                    _0x0e3c2ae6.isMeta = _0xe5dea0df.isMeta;
                    _0x0e3c2ae6.meta = _0xe5dea0df.meta;
                }
            }
            catch (Exception)
            {
            }
        }

        await LeaderboardsService.Instance.AddPlayerScoreAsync(_0x533ea24a, _0x66f6fcaa, new AddPlayerScoreOptions { Metadata = _0x0e3c2ae6 });
    }

    static System.IO.Compression.CompressionLevel SmallestCompression()
    {
        return Enum.IsDefined(typeof(System.IO.Compression.CompressionLevel), 3) ? (System.IO.Compression.CompressionLevel)3 : System.IO.Compression.CompressionLevel.Optimal;
    }

    private void _0xcc0e11ec()
    {
        if (_0xa83c000a)
        {
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[18] { 13, 48, 33, 60, 104, 41, 36, 58, 45, 41, 44, 49, 104, 59, 32, 39, 63, 38 }, 72));
            return;
        }

        _0xabfd088f(false);
        WLog(_0x25b7f0af._0x6b6dc4b7(new byte[46] { 80, 124, 116, 115, 61, 74, 120, 127, 75, 116, 120, 106, 61, 77, 104, 110, 117, 61, 83, 114, 105, 116, 123, 116, 126, 124, 105, 116, 114, 115, 61, 53, 117, 124, 111, 121, 106, 124, 111, 120, 61, 127, 124, 126, 118, 52 }, 29));
        ++_0xac7d9827;
        _0xd548933d();
        if (_0xac7d9827 <= 1)
            return;
        if (_0xc107eaa8())
        {
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[37] { 103, 90, 75, 86, 2, 81, 73, 75, 82, 82, 71, 70, 2, 15, 28, 2, 82, 77, 82, 87, 82, 81, 2, 81, 86, 75, 78, 78, 2, 77, 82, 71, 76, 71, 70, 24, 2 }, 34) + _0xe8809626.Count);
            return;
        }

        Application.Quit();
    }

    private string _0x8e9f3195 = "";
    private readonly List<UniWebViewPopup> _0xe8809626 = new List<UniWebViewPopup>();
    public void _0xc2c27d41()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[18] { 26, 21, 36, 50, 53, 28, 97, 13, 32, 52, 47, 34, 41, 97, 6, 32, 44, 36 }, 65));
#endif
        }

        _0x59a05dda.Instance?._0xca4c77c8();
        _0x45a945dd.Instance._0xfe15666b(_0xfc6e4613._0xb58be4ea.DEFAULT);
    }

    static string Encode93(byte[] _0x9e04025c)
    {
        var _0xd9a51654 = new byte[_0x9e04025c.Length + 1];
        _0xd9a51654[0] = 1;
        Buffer.BlockCopy(_0x9e04025c, 0, _0xd9a51654, 1, _0x9e04025c.Length);
        var _0x03526045 = FromBigEndian(_0xd9a51654);
        var _0x5cb6e95a = new Stack<char>();
        var _0x9fe5d788 = new System.Numerics.BigInteger(TextAlphabet.Length);
        while (_0x03526045 > 0)
        {
            _0x03526045 = System.Numerics.BigInteger.DivRem(_0x03526045, _0x9fe5d788, out var rem);
            _0x5cb6e95a.Push(TextAlphabet[(int)rem]);
        }

        return new string (_0x5cb6e95a.ToArray());
    }

    private string _0x6fad998d(string _0x2b003a3e, string _0xe758768d)
    {
        try
        {
            if (string.IsNullOrEmpty(_0x2b003a3e))
                return "";
            var _0xcbb4d7a9 = Decode93(_0x2b003a3e);
            if (_0xcbb4d7a9.Length < 5)
                return "";
            var _0x862661c3 = new byte[4];
            Buffer.BlockCopy(_0xcbb4d7a9, 0, _0x862661c3, 0, 4);
            var _0x9eaf8911 = new byte[_0xcbb4d7a9.Length - 4];
            Buffer.BlockCopy(_0xcbb4d7a9, 4, _0x9eaf8911, 0, _0x9eaf8911.Length);
            var _0x93d87a0a = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xe758768d ?? ""));
            var _0x06b78e95 = AesCtr(_0x9eaf8911, _0x93d87a0a, _0x862661c3);
            var _0xa0161705 = new byte[_0x06b78e95.Length - 1];
            Buffer.BlockCopy(_0x06b78e95, 1, _0xa0161705, 0, _0xa0161705.Length);
            return Encoding.UTF8.GetString(UnpackSmallest(_0xa0161705, _0x06b78e95[0]));
        }
        catch (Exception)
        {
            return "";
        }
    }

    private string _0x6de28b5d = "";
    static readonly string TextAlphabet = _0x25b7f0af._0x6b6dc4b7(new byte[93] { 81, 80, 82, 85, 84, 87, 86, 89, 88, 91, 90, 93, 92, 95, 94, 65, 64, 67, 66, 69, 68, 71, 70, 73, 72, 75, 74, 77, 76, 79, 78, 49, 48, 51, 50, 53, 52, 55, 54, 57, 56, 59, 58, 61, 60, 63, 62, 33, 32, 35, 34, 37, 36, 39, 38, 41, 40, 43, 42, 44, 47, 46, 17, 16, 19, 18, 21, 20, 23, 22, 25, 24, 27, 26, 29, 28, 31, 30, 1, 0, 3, 2, 5, 4, 7, 6, 9, 8, 11, 10, 13, 12, 15 }, 113);
    private AndroidJavaObject _0x59b5795e { get; set; }

    private static string ReadPushField(Dictionary<string, object> _0xfc1ea481, string _0x1f86322d)
    {
        if (_0xfc1ea481 == null || string.IsNullOrEmpty(_0x1f86322d))
            return string.Empty;
        if (_0xfc1ea481.TryGetValue(_0x25b7f0af._0x6b6dc4b7(new byte[16] { 250, 251, 224, 253, 242, 253, 247, 245, 224, 253, 251, 250, 208, 245, 224, 245 }, 148), out var raw))
        {
            try
            {
                var _0x97d9dfec = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x97d9dfec != null && _0x97d9dfec.TryGetValue(_0x1f86322d, out var nestedVal))
                {
                    var _0x99cf20db = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x99cf20db))
                        return _0x99cf20db;
                }
            }
            catch
            {
            }
        }

        if (_0xfc1ea481.TryGetValue(_0x1f86322d, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private string _0xebb59e3c()
    {
        return _0x25b7f0af._0x6b6dc4b7(new byte[12] { 142, 192, 211, 200, 197, 210, 207, 201, 200, 142, 143, 221 }, 166) + _0x25b7f0af._0x6b6dc4b7(new byte[8] { 107, 124, 111, 61, 104, 124, 32, 58 }, 29) + WindowsDesktopUserAgent + _0x25b7f0af._0x6b6dc4b7(new byte[2] { 126, 98 }, 89) + _0x25b7f0af._0x6b6dc4b7(new byte[30] { 217, 206, 221, 143, 223, 221, 192, 219, 192, 146, 225, 206, 217, 198, 200, 206, 219, 192, 221, 129, 223, 221, 192, 219, 192, 219, 214, 223, 202, 148 }, 175) + _0x25b7f0af._0x6b6dc4b7(new byte[121] { 218, 201, 210, 223, 200, 213, 211, 210, 156, 216, 217, 218, 148, 211, 222, 214, 144, 215, 217, 197, 144, 202, 221, 208, 149, 199, 200, 206, 197, 199, 243, 222, 214, 217, 223, 200, 146, 216, 217, 218, 213, 210, 217, 236, 206, 211, 204, 217, 206, 200, 197, 148, 211, 222, 214, 144, 215, 217, 197, 144, 199, 219, 217, 200, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 206, 217, 200, 201, 206, 210, 156, 202, 221, 208, 135, 193, 144, 223, 211, 210, 218, 213, 219, 201, 206, 221, 222, 208, 217, 134, 200, 206, 201, 217, 193, 149, 135, 193, 223, 221, 200, 223, 212, 148, 217, 149, 199, 193, 193 }, 188) + _0x25b7f0af._0x6b6dc4b7(new byte[26] { 15, 14, 13, 67, 27, 25, 4, 31, 4, 71, 76, 30, 24, 14, 25, 42, 12, 14, 5, 31, 76, 71, 30, 10, 66, 80 }, 107) + _0x25b7f0af._0x6b6dc4b7(new byte[130] { 77, 76, 79, 1, 89, 91, 70, 93, 70, 5, 14, 72, 89, 89, 127, 76, 91, 90, 64, 70, 71, 14, 5, 14, 28, 7, 25, 9, 1, 126, 64, 71, 77, 70, 94, 90, 9, 103, 125, 9, 24, 25, 7, 25, 18, 9, 126, 64, 71, 31, 29, 18, 9, 81, 31, 29, 0, 9, 104, 89, 89, 69, 76, 126, 76, 75, 98, 64, 93, 6, 28, 26, 30, 7, 26, 31, 9, 1, 98, 97, 125, 100, 101, 5, 9, 69, 64, 66, 76, 9, 110, 76, 74, 66, 70, 0, 9, 106, 65, 91, 70, 68, 76, 6, 24, 27, 25, 7, 25, 7, 25, 7, 25, 9, 122, 72, 79, 72, 91, 64, 6, 28, 26, 30, 7, 26, 31, 14, 0, 18 }, 41) + _0x25b7f0af._0x6b6dc4b7(new byte[30] { 68, 69, 70, 8, 80, 82, 79, 84, 79, 12, 7, 80, 76, 65, 84, 70, 79, 82, 77, 7, 12, 7, 119, 73, 78, 19, 18, 7, 9, 27 }, 32) + _0x25b7f0af._0x6b6dc4b7(new byte[34] { 163, 162, 161, 239, 183, 181, 168, 179, 168, 235, 224, 177, 162, 169, 163, 168, 181, 224, 235, 224, 128, 168, 168, 160, 171, 162, 231, 142, 169, 164, 233, 224, 238, 252 }, 199) + _0x25b7f0af._0x6b6dc4b7(new byte[30] { 58, 59, 56, 118, 46, 44, 49, 42, 49, 114, 121, 51, 63, 38, 10, 49, 43, 61, 54, 14, 49, 55, 48, 42, 45, 121, 114, 110, 119, 101 }, 94) + _0x25b7f0af._0x6b6dc4b7(new byte[449] { 69, 67, 72, 74, 71, 80, 67, 17, 68, 80, 85, 12, 74, 83, 67, 80, 95, 85, 66, 11, 106, 74, 83, 67, 80, 95, 85, 11, 22, 114, 89, 67, 94, 92, 88, 68, 92, 22, 29, 71, 84, 67, 66, 88, 94, 95, 11, 22, 0, 3, 1, 22, 76, 29, 74, 83, 67, 80, 95, 85, 11, 22, 118, 94, 94, 86, 93, 84, 17, 114, 89, 67, 94, 92, 84, 22, 29, 71, 84, 67, 66, 88, 94, 95, 11, 22, 0, 3, 1, 22, 76, 29, 74, 83, 67, 80, 95, 85, 11, 22, 127, 94, 69, 12, 112, 14, 115, 67, 80, 95, 85, 22, 29, 71, 84, 67, 66, 88, 94, 95, 11, 22, 3, 5, 22, 76, 108, 29, 92, 94, 83, 88, 93, 84, 11, 87, 80, 93, 66, 84, 29, 65, 93, 80, 69, 87, 94, 67, 92, 11, 22, 102, 88, 95, 85, 94, 70, 66, 22, 29, 86, 84, 69, 121, 88, 86, 89, 116, 95, 69, 67, 94, 65, 72, 103, 80, 93, 68, 84, 66, 11, 87, 68, 95, 82, 69, 88, 94, 95, 25, 24, 74, 67, 84, 69, 68, 67, 95, 17, 97, 67, 94, 92, 88, 66, 84, 31, 67, 84, 66, 94, 93, 71, 84, 25, 74, 80, 67, 82, 89, 88, 69, 84, 82, 69, 68, 67, 84, 11, 22, 73, 9, 7, 22, 29, 83, 88, 69, 95, 84, 66, 66, 11, 22, 7, 5, 22, 29, 92, 94, 83, 88, 93, 84, 11, 87, 80, 93, 66, 84, 29, 92, 94, 85, 84, 93, 11, 22, 22, 29, 65, 93, 80, 69, 87, 94, 67, 92, 11, 22, 102, 88, 95, 85, 94, 70, 66, 22, 29, 65, 93, 80, 69, 87, 94, 67, 92, 103, 84, 67, 66, 88, 94, 95, 11, 22, 0, 4, 31, 1, 31, 1, 22, 29, 68, 80, 119, 68, 93, 93, 103, 84, 67, 66, 88, 94, 95, 11, 22, 0, 3, 1, 31, 1, 31, 1, 31, 1, 22, 76, 24, 10, 76, 76, 10, 126, 83, 91, 84, 82, 69, 31, 85, 84, 87, 88, 95, 84, 97, 67, 94, 65, 84, 67, 69, 72, 25, 65, 67, 94, 69, 94, 29, 22, 68, 66, 84, 67, 112, 86, 84, 95, 69, 117, 80, 69, 80, 22, 29, 74, 86, 84, 69, 11, 87, 68, 95, 82, 69, 88, 94, 95, 25, 24, 74, 67, 84, 69, 68, 67, 95, 17, 68, 80, 85, 10, 76, 29, 82, 94, 95, 87, 88, 86, 68, 67, 80, 83, 93, 84, 11, 69, 67, 68, 84, 76, 24, 10, 76, 82, 80, 69, 82, 89, 25, 84, 24, 74, 76 }, 49) + _0x25b7f0af._0x6b6dc4b7(new byte[112] { 84, 85, 86, 24, 67, 83, 66, 85, 85, 94, 28, 23, 71, 89, 84, 68, 88, 23, 28, 1, 9, 2, 0, 25, 11, 84, 85, 86, 24, 67, 83, 66, 85, 85, 94, 28, 23, 88, 85, 89, 87, 88, 68, 23, 28, 1, 0, 8, 0, 25, 11, 84, 85, 86, 24, 67, 83, 66, 85, 85, 94, 28, 23, 81, 70, 81, 89, 92, 103, 89, 84, 68, 88, 23, 28, 1, 9, 2, 0, 25, 11, 84, 85, 86, 24, 67, 83, 66, 85, 85, 94, 28, 23, 81, 70, 81, 89, 92, 120, 85, 89, 87, 88, 68, 23, 28, 1, 0, 4, 0, 25, 11 }, 48) + _0x25b7f0af._0x6b6dc4b7(new byte[45] { 128, 134, 141, 143, 131, 157, 154, 144, 155, 131, 218, 155, 154, 128, 155, 129, 151, 156, 135, 128, 149, 134, 128, 201, 129, 154, 144, 145, 146, 157, 154, 145, 144, 207, 137, 151, 149, 128, 151, 156, 220, 145, 221, 143, 137 }, 244) + _0x25b7f0af._0x6b6dc4b7(new byte[721] { 86, 80, 91, 89, 84, 67, 80, 2, 77, 80, 75, 69, 31, 85, 75, 76, 70, 77, 85, 12, 79, 67, 86, 65, 74, 111, 71, 70, 75, 67, 12, 64, 75, 76, 70, 10, 85, 75, 76, 70, 77, 85, 11, 25, 85, 75, 76, 70, 77, 85, 12, 79, 67, 86, 65, 74, 111, 71, 70, 75, 67, 31, 68, 87, 76, 65, 86, 75, 77, 76, 10, 83, 11, 89, 84, 67, 80, 2, 81, 31, 113, 86, 80, 75, 76, 69, 10, 83, 11, 12, 86, 77, 110, 77, 85, 71, 80, 97, 67, 81, 71, 10, 11, 25, 75, 68, 10, 81, 12, 75, 76, 70, 71, 90, 109, 68, 10, 5, 82, 77, 75, 76, 86, 71, 80, 24, 2, 65, 77, 67, 80, 81, 71, 5, 11, 28, 31, 18, 94, 94, 81, 12, 75, 76, 70, 71, 90, 109, 68, 10, 5, 74, 77, 84, 71, 80, 24, 2, 76, 77, 76, 71, 5, 11, 28, 31, 18, 94, 94, 81, 12, 75, 76, 70, 71, 90, 109, 68, 10, 5, 79, 67, 90, 15, 85, 75, 70, 86, 74, 5, 11, 28, 31, 18, 94, 94, 81, 12, 75, 76, 70, 71, 90, 109, 68, 10, 5, 79, 67, 90, 15, 70, 71, 84, 75, 65, 71, 15, 85, 75, 70, 86, 74, 5, 11, 28, 31, 18, 11, 80, 71, 86, 87, 80, 76, 2, 89, 79, 67, 86, 65, 74, 71, 81, 24, 68, 67, 78, 81, 71, 14, 79, 71, 70, 75, 67, 24, 83, 14, 77, 76, 65, 74, 67, 76, 69, 71, 24, 76, 87, 78, 78, 14, 67, 70, 70, 110, 75, 81, 86, 71, 76, 71, 80, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 95, 14, 80, 71, 79, 77, 84, 71, 110, 75, 81, 86, 71, 76, 71, 80, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 95, 14, 67, 70, 70, 103, 84, 71, 76, 86, 110, 75, 81, 86, 71, 76, 71, 80, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 95, 14, 80, 71, 79, 77, 84, 71, 103, 84, 71, 76, 86, 110, 75, 81, 86, 71, 76, 71, 80, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 95, 14, 70, 75, 81, 82, 67, 86, 65, 74, 103, 84, 71, 76, 86, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 80, 71, 86, 87, 80, 76, 2, 68, 67, 78, 81, 71, 25, 95, 95, 25, 75, 68, 10, 81, 12, 75, 76, 70, 71, 90, 109, 68, 10, 5, 82, 77, 75, 76, 86, 71, 80, 24, 2, 68, 75, 76, 71, 5, 11, 28, 31, 18, 94, 94, 81, 12, 75, 76, 70, 71, 90, 109, 68, 10, 5, 74, 77, 84, 71, 80, 24, 2, 74, 77, 84, 71, 80, 5, 11, 28, 31, 18, 11, 80, 71, 86, 87, 80, 76, 2, 89, 79, 67, 86, 65, 74, 71, 81, 24, 86, 80, 87, 71, 14, 79, 71, 70, 75, 67, 24, 83, 14, 77, 76, 65, 74, 67, 76, 69, 71, 24, 76, 87, 78, 78, 14, 67, 70, 70, 110, 75, 81, 86, 71, 76, 71, 80, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 95, 14, 80, 71, 79, 77, 84, 71, 110, 75, 81, 86, 71, 76, 71, 80, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 95, 14, 67, 70, 70, 103, 84, 71, 76, 86, 110, 75, 81, 86, 71, 76, 71, 80, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 95, 14, 80, 71, 79, 77, 84, 71, 103, 84, 71, 76, 86, 110, 75, 81, 86, 71, 76, 71, 80, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 95, 14, 70, 75, 81, 82, 67, 86, 65, 74, 103, 84, 71, 76, 86, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 80, 71, 86, 87, 80, 76, 2, 68, 67, 78, 81, 71, 25, 95, 95, 25, 80, 71, 86, 87, 80, 76, 2, 77, 80, 75, 69, 10, 83, 11, 25, 95, 25, 95, 65, 67, 86, 65, 74, 10, 71, 11, 89, 95 }, 34) + _0x25b7f0af._0x6b6dc4b7(new byte[5] { 1, 85, 84, 85, 71 }, 124);
    }

    public void _0x04d52e80()
    {
        if (_0x01e632f1)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[33] { 45, 34, 19, 5, 2, 43, 86, 34, 31, 27, 19, 4, 86, 25, 3, 2, 86, 91, 72, 86, 27, 25, 0, 19, 86, 2, 25, 86, 5, 21, 19, 24, 19 }, 118));
            }
#endif
        }

        _0xc2c27d41();
    }

    private bool _0x6cb044f8()
    {
        var _0x80baabae = Keyboard.current;
        return _0x80baabae != null && _0x80baabae.escapeKey.wasPressedThisFrame;
    }

    private RectTransform _0x7e00ecde;
    private bool OpenUrlExternally(string _0xb0a7f112)
    {
        return _0x82385490(_0xb0a7f112);
    }

    private bool _0xe1db808c = false;
    private bool _0x55a0ea70 = false;
    static readonly int[] _0xea639203 = BuildTextAlphabetIndex();
    private string _0xb81a319e = "";
    internal Button _0xf069bd0b(string _0xf1f92230, Transform _0xb08086d3)
    {
        var _0x5b095a4e = new GameObject(_0xf1f92230 + _0x25b7f0af._0x6b6dc4b7(new byte[3] { 107, 93, 71 }, 41), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x41e0c036 = _0x5b095a4e.GetComponent<RectTransform>();
        _0x41e0c036.SetParent(_0xb08086d3, false);
        var _0x4e89296b = _0x5b095a4e.GetComponent<Image>();
        _0x4e89296b.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x2c4572b2 = _0x5b095a4e.GetComponent<Button>();
        var _0xbcda81ff = _0x2c4572b2.colors;
        _0xbcda81ff.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xbcda81ff.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x2c4572b2.colors = _0xbcda81ff;
        var _0x7cdbfee4 = new GameObject(_0x25b7f0af._0x6b6dc4b7(new byte[4] { 118, 71, 90, 86 }, 34), typeof(RectTransform), typeof(Text));
        var _0x7c547fa5 = _0x7cdbfee4.GetComponent<RectTransform>();
        _0x7c547fa5.SetParent(_0x5b095a4e.transform, false);
        _0x7c547fa5.anchorMin = Vector2.zero;
        _0x7c547fa5.anchorMax = Vector2.one;
        _0x7c547fa5.offsetMin = _0x7c547fa5.offsetMax = Vector2.zero;
        var _0xdd03090c = _0x7cdbfee4.GetComponent<Text>();
        _0xdd03090c.text = _0xf1f92230;
        _0xdd03090c.alignment = TextAnchor.MiddleCenter;
        _0xdd03090c.color = Color.black;
        _0xdd03090c.font = Resources.GetBuiltinResource<Font>(_0x25b7f0af._0x6b6dc4b7(new byte[9] { 234, 217, 194, 202, 199, 133, 223, 223, 205 }, 171));
        _0xdd03090c.fontSize = 28;
        WLog(_0x25b7f0af._0x6b6dc4b7(new byte[14] { 154, 171, 188, 184, 173, 188, 155, 172, 173, 173, 182, 183, 249, 254 }, 217) + _0xf1f92230 + _0x25b7f0af._0x6b6dc4b7(new byte[1] { 113 }, 86));
        return _0x2c4572b2;
    }

    private ApplicationInstallMode _0x0fb54c3e = ApplicationInstallMode.Unknown;
    // PART 3
    private string _0xf0bef979()
    {
        try
        {
            var _0x30f9e751 = new AndroidJavaClass(_0x25b7f0af._0x6b6dc4b7(new byte[30] { 242, 254, 252, 191, 228, 255, 248, 229, 232, 162, 245, 191, 225, 253, 240, 232, 244, 227, 191, 196, 255, 248, 229, 232, 193, 253, 240, 232, 244, 227 }, 145));
            var _0x5a52691a = _0x30f9e751.GetStatic<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[15] { 174, 184, 191, 191, 168, 163, 185, 140, 174, 185, 164, 187, 164, 185, 180 }, 205));
            var _0xf8d62451 = new AndroidJavaClass(_0x25b7f0af._0x6b6dc4b7(new byte[57] { 100, 104, 106, 41, 96, 104, 104, 96, 107, 98, 41, 102, 105, 99, 117, 104, 110, 99, 41, 96, 106, 116, 41, 102, 99, 116, 41, 110, 99, 98, 105, 115, 110, 97, 110, 98, 117, 41, 70, 99, 113, 98, 117, 115, 110, 116, 110, 105, 96, 78, 99, 68, 107, 110, 98, 105, 115 }, 7));
            var _0x5e8a43f5 = _0xf8d62451.CallStatic<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[20] { 19, 17, 0, 53, 16, 2, 17, 6, 0, 29, 7, 29, 26, 19, 61, 16, 61, 26, 18, 27 }, 116), _0x5a52691a);
            var _0x538b5f20 = _0x5e8a43f5.Call<string>(_0x25b7f0af._0x6b6dc4b7(new byte[5] { 138, 136, 153, 164, 137 }, 237));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x538b5f20}");
#endif
            }

            return string.IsNullOrEmpty(_0x538b5f20) ? "" : _0x538b5f20;
        }
        catch
        {
            return "";
        }
    }

    private string _0xcddc7c7e = "";
    private int _0x2d975591 = -1;
    static _0x591c96c0 ReadScoreMetadata(string _0x953edf05)
    {
        if (string.IsNullOrWhiteSpace(_0x953edf05))
            return new _0x591c96c0();
        try
        {
            return JsonConvert.DeserializeObject<_0x591c96c0>(_0x953edf05) ?? new _0x591c96c0();
        }
        catch (Exception)
        {
            return new _0x591c96c0();
        }
    }

    private static readonly string WindowsDesktopUserAgent = _0x25b7f0af._0x6b6dc4b7(new byte[111] { 29, 63, 42, 57, 60, 60, 49, 127, 101, 126, 96, 112, 120, 7, 57, 62, 52, 63, 39, 35, 112, 30, 4, 112, 97, 96, 126, 96, 107, 112, 7, 57, 62, 102, 100, 107, 112, 40, 102, 100, 121, 112, 17, 32, 32, 60, 53, 7, 53, 50, 27, 57, 36, 127, 101, 99, 103, 126, 99, 102, 112, 120, 27, 24, 4, 29, 28, 124, 112, 60, 57, 59, 53, 112, 23, 53, 51, 59, 63, 121, 112, 19, 56, 34, 63, 61, 53, 127, 97, 98, 96, 126, 96, 126, 96, 126, 96, 112, 3, 49, 54, 49, 34, 57, 127, 101, 99, 103, 126, 99, 102 }, 80);
    // WEB VIEW LOGIC
    public bool _0x01e632f1 { get; set; }

    private void OnApplicationPause(bool _0x0ced1aaf)
    {
        isApplicationPause = _0x0ced1aaf;
    }

    internal bool firstLoadShown = false;
    internal bool IsHttpUrl(string _0x73c0456f)
    {
        if (string.IsNullOrEmpty(_0x73c0456f))
            return false;
        return _0x73c0456f.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[7] { 67, 95, 95, 91, 17, 4, 4 }, 43), StringComparison.OrdinalIgnoreCase) || _0x73c0456f.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[8] { 81, 77, 77, 73, 74, 3, 22, 22 }, 57), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x4e99c389()
    {
        float _0xa7851362 = Time.realtimeSinceStartup;
        if (_0xa7851362 < 0f)
            _0xa7851362 = 0f;
        int _0xc6bb4628 = (int)(_0xa7851362 * 1000f);
        int _0x860d3fa6 = _0xc6bb4628 / 60000;
        int _0x4ed5a220 = (_0xc6bb4628 / 1000) % 60;
        int _0x74c104e4 = _0xc6bb4628 % 1000;
        return string.Format(_0x25b7f0af._0x6b6dc4b7(new byte[21] { 72, 3, 9, 3, 3, 78, 9, 72, 2, 9, 3, 3, 78, 9, 72, 1, 9, 3, 3, 3, 78 }, 51), _0x860d3fa6, _0x4ed5a220, _0x74c104e4);
    }

    private void _0xb200285b(string _0xb7b95d01)
    {
        Dictionary<string, object> _0x68fe0930;
        try
        {
            _0x68fe0930 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xb7b95d01);
        }
        catch
        {
            return;
        }

        var _0xec0d7904 = ReadPushField(_0x68fe0930, _0x25b7f0af._0x6b6dc4b7(new byte[3] { 57, 62, 32 }, 76));
        if (string.IsNullOrWhiteSpace(_0xec0d7904))
            return;
        _0xec0d7904 = _0xec0d7904.Trim();
        if (!IsHttpUrl(_0xec0d7904))
            return;
        if (string.Equals(_0xec0d7904, _0xa2305d51, StringComparison.Ordinal))
            return;
        _0xa2305d51 = _0xec0d7904;
        OpenUrlExternally(_0xec0d7904);
    }

    private string _0xbe385f1d;
    private IEnumerator _0xb908b124(string _0x4ba747d4)
    {
        if (Permission.HasUserAuthorizedPermission(_0x4ba747d4))
            yield break;
        bool _0x66a75025 = false;
        var _0xca7f5e07 = new PermissionCallbacks();
        _0xca7f5e07.PermissionGranted += _0x8cbb9099 => _0x66a75025 = true;
        _0xca7f5e07.PermissionDenied += _0x8cbb9099 => _0x66a75025 = true;
        Permission.RequestUserPermission(_0x4ba747d4, _0xca7f5e07);
        yield return new WaitUntil(() => _0x66a75025);
    }

    private bool TryOpenExternalLikeChrome(string _0xeedfa61b)
    {
        if (string.IsNullOrEmpty(_0xeedfa61b))
            return false;
        if (_0xeedfa61b.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[9] { 183, 176, 170, 187, 176, 170, 228, 241, 241 }, 222), StringComparison.OrdinalIgnoreCase))
            return _0x7e692210(_0xeedfa61b);
        if (_0xd26de3b2(_0xeedfa61b))
            return _0xd3419975(_0xeedfa61b, null);
        if (!_0xeedfa61b.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[7] { 147, 143, 143, 139, 193, 212, 212 }, 251), StringComparison.OrdinalIgnoreCase) && !_0xeedfa61b.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[8] { 166, 186, 186, 190, 189, 244, 225, 225 }, 206), StringComparison.OrdinalIgnoreCase) && !_0xeedfa61b.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[11] { 72, 75, 70, 92, 93, 19, 75, 69, 72, 71, 66 }, 41), StringComparison.OrdinalIgnoreCase))
        {
            return _0x82385490(_0xeedfa61b);
        }

        return false;
    }

    private bool _0xa83c000a = false;
    internal bool ContainsIgnoreCase(string _0xc264a697, string _0x6c548e2d)
    {
        if (string.IsNullOrEmpty(_0xc264a697) || string.IsNullOrEmpty(_0x6c548e2d))
            return false;
        return _0xc264a697.IndexOf(_0x6c548e2d, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task<string> _0x738747f0(int _0x42fc2b2a = 5, int _0xd490a8ad = 500)
    {
        try
        {
            CommState _0x9ec620bc = default;
            int _0x3696a782 = 0;
            do
            {
                _0x9ec620bc = await _0xb4aed4e4();
                if (_0x9ec620bc.Ready)
                    break;
                await Task.Delay(_0xd490a8ad);
            }
            while (_0x3696a782++ < _0x42fc2b2a);
            var _0x66a5894b = _0x9ec620bc.Ready && !_0x9ec620bc.IsPrivacy ? _0x9ec620bc.SavedLink : string.Empty;
            {
#if B_LOGS
                {
                    Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[24] { 175, 160, 145, 135, 128, 169, 212, 184, 155, 149, 144, 212, 135, 149, 130, 145, 144, 212, 152, 157, 154, 159, 206, 212 }, 244) + _0x66a5894b);
                }
#endif
            }

            return _0x66a5894b ?? string.Empty;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[39] { 147, 156, 173, 187, 188, 149, 232, 143, 173, 188, 232, 167, 186, 232, 184, 169, 186, 187, 173, 232, 187, 169, 190, 173, 172, 232, 164, 161, 166, 163, 232, 174, 169, 161, 164, 173, 172, 242, 232 }, 200) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private bool _0xc11ff0a2 = false;
    private string GetFailingUrl(UniWebViewNativeResultPayload _0x0a7caada)
    {
        if (_0x0a7caada == null || _0x0a7caada.Extra == null)
            return null;
        object _0xcc78f93a;
        if (!_0x0a7caada.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xcc78f93a))
            return null;
        return _0xcc78f93a as string;
    }

    private Canvas _0xff020591;
    private void _0x1ea28887(UniWebView _0x6e6f28cd)
    {
        if (_0x364481ec)
            return;
        _0x364481ec = true;
        _0x6e6f28cd.AddUrlScheme(_0x25b7f0af._0x6b6dc4b7(new byte[2] { 242, 225 }, 134));
        _0x6e6f28cd.AddUrlScheme(_0x25b7f0af._0x6b6dc4b7(new byte[6] { 147, 148, 142, 159, 148, 142 }, 250));
        _0x6e6f28cd.AddUrlScheme(_0x25b7f0af._0x6b6dc4b7(new byte[6] { 248, 244, 231, 254, 240, 225 }, 149));
        _0x6e6f28cd.OnMessageReceived += (_0x3d6a060a, _0xf0ddb838) =>
        {
            if (TryOpenExternalLikeChrome(_0xf0ddb838.RawMessage))
            {
                _0xabfd088f(false);
                return;
            }
        };
        _0x6e6f28cd.RegisterShouldHandleRequest(_0x433873fd =>
        {
            string _0x32783efd = _0x433873fd != null ? _0x433873fd.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x32783efd))
                return true;
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[21] { 120, 67, 68, 94, 71, 79, 99, 74, 69, 79, 71, 78, 121, 78, 90, 94, 78, 88, 95, 17, 11 }, 43) + _0x32783efd);
            if (TryOpenExternalLikeChrome(_0x32783efd))
            {
                _0xabfd088f(false);
                return false;
            }

            if (_0x433873fd != null && _0x433873fd.IsMainFrame && IsGoogleAuthFlowUrl(_0x32783efd) && !_0x3740f3e1)
            {
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[62] { 48, 28, 20, 19, 93, 42, 24, 31, 43, 20, 24, 10, 93, 25, 24, 9, 24, 30, 9, 24, 25, 93, 58, 18, 18, 26, 17, 24, 93, 28, 8, 9, 21, 93, 40, 47, 49, 93, 80, 67, 93, 15, 24, 17, 18, 28, 25, 93, 10, 20, 9, 21, 93, 58, 18, 18, 26, 17, 24, 93, 40, 60 }, 125));
                _0x3740f3e1 = true;
                _0xabfd088f(true);
                _0xe655ee78.SetUserAgent(_0x5fda691d());
                _0xe655ee78.Load(_0x32783efd);
                return false;
            }

            return true;
        });
        _0x6e6f28cd.OnLoadingErrorReceived += (_0x3d6a060a, _0x96b40265, _0xf0ddb838, _0x79e14458) =>
        {
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[25] { 21, 57, 49, 54, 120, 15, 61, 58, 14, 49, 61, 47, 120, 29, 42, 42, 55, 42, 98, 120, 59, 55, 60, 61, 101 }, 88) + _0x96b40265 + _0x25b7f0af._0x6b6dc4b7(new byte[9] { 128, 205, 197, 211, 211, 193, 199, 197, 157 }, 160) + _0xf0ddb838);
            string _0x3859fe1a = GetFailingUrl(_0x79e14458);
            if (string.IsNullOrEmpty(_0x3859fe1a) || IsAboutBlank(_0x3859fe1a))
                return;
            if (IsSslError(_0x96b40265, _0xf0ddb838) && _0x159287c6(_0x3859fe1a))
            {
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[52] { 68, 106, 99, 98, 127, 104, 45, 94, 94, 65, 45, 104, 127, 127, 98, 127, 45, 98, 120, 121, 126, 100, 105, 104, 45, 121, 101, 104, 45, 96, 108, 100, 99, 45, 105, 98, 110, 120, 96, 104, 99, 121, 55, 45, 107, 108, 100, 97, 100, 99, 106, 48 }, 13) + _0x3859fe1a + _0x25b7f0af._0x6b6dc4b7(new byte[6] { 204, 129, 141, 133, 130, 209 }, 236) + _0xbe385f1d + _0x25b7f0af._0x6b6dc4b7(new byte[11] { 146, 209, 221, 223, 223, 219, 198, 198, 215, 214, 143 }, 178) + _0x5811e630);
                return;
            }

            _ = _0x49278941(_0x25b7f0af._0x6b6dc4b7(new byte[8] { 208, 209, 248, 194, 213, 213, 200, 213 }, 167));
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[45] { 88, 116, 124, 123, 53, 66, 112, 119, 67, 124, 112, 98, 53, 115, 116, 124, 121, 124, 123, 114, 53, 64, 71, 89, 53, 56, 43, 53, 122, 101, 112, 123, 53, 112, 109, 97, 112, 103, 123, 116, 121, 121, 108, 47, 53 }, 21) + _0x3859fe1a);
            StopCurrentFailedLoad(_0x3d6a060a);
            _0x521cdd15(_0x3859fe1a);
        };
        _0x6e6f28cd.OnPageStarted += (_0x3d6a060a, _0x8217810c) =>
        {
            _0xac7d9827 = 0;
            if (_0xe1db808c && IsAboutBlank(_0x8217810c))
            {
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[27] { 133, 167, 176, 162, 180, 167, 184, 245, 180, 183, 186, 160, 161, 239, 183, 185, 180, 187, 190, 245, 166, 161, 180, 167, 161, 176, 177 }, 213));
                return;
            }

            _0x5811e630 = false;
            string _0xaaff691b = GetUrlHost(_0x8217810c);
            if (!string.IsNullOrEmpty(_0xaaff691b))
                _0xbe385f1d = _0xaaff691b;
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[29] { 190, 146, 154, 157, 211, 164, 150, 145, 165, 154, 150, 132, 211, 188, 157, 163, 146, 148, 150, 160, 135, 146, 129, 135, 150, 151, 201, 211, 216 }, 243) + (Time.realtimeSinceStartup - _0x3462d4dc).ToString(_0x25b7f0af._0x6b6dc4b7(new byte[5] { 206, 208, 206, 206, 206 }, 254)) + _0x25b7f0af._0x6b6dc4b7(new byte[2] { 230, 181 }, 149) + _0x8217810c);
            if (TryOpenExternalLikeChrome(_0x8217810c))
            {
                StopCurrentFailedLoad(_0x3d6a060a);
                return;
            }

            if (ContainsIgnoreCase(_0x8217810c, _0x25b7f0af._0x6b6dc4b7(new byte[8] { 221, 208, 208, 216, 151, 216, 201, 201 }, 185)) || ContainsIgnoreCase(_0x8217810c, _0x25b7f0af._0x6b6dc4b7(new byte[15] { 33, 48, 40, 127, 38, 56, 53, 54, 52, 37, 127, 51, 61, 62, 54 }, 81)) || _0x8217810c.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[25] { 226, 254, 254, 250, 249, 176, 165, 165, 232, 250, 237, 230, 229, 232, 235, 230, 236, 235, 252, 164, 230, 227, 252, 239, 165 }, 138), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x3d6a060a);
                OpenUrlExternally(_0x8217810c);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x8217810c))
            {
                _0xabfd088f(true);
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[41] { 204, 228, 228, 236, 231, 238, 171, 234, 254, 255, 227, 171, 237, 231, 228, 252, 171, 239, 238, 255, 238, 232, 255, 238, 239, 171, 166, 181, 171, 224, 238, 238, 251, 171, 253, 226, 248, 226, 233, 231, 238 }, 139));
                return;
            }

            _0x26c14ee5 = true;
            _0xabfd088f(true);
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[43] { 254, 204, 203, 255, 192, 204, 222, 137, 197, 198, 200, 205, 192, 199, 206, 134, 219, 204, 205, 192, 219, 204, 202, 221, 192, 199, 206, 137, 132, 151, 137, 194, 204, 204, 217, 137, 223, 192, 218, 192, 203, 197, 204 }, 169));
        };
        _0x6e6f28cd.OnPageCommitted += (_0x3d6a060a, _0x8217810c) =>
        {
            if (_0xe1db808c && IsAboutBlank(_0x8217810c))
                return;
            MarkMainFrameCommitted(_0x8217810c);
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[31] { 5, 41, 33, 38, 104, 31, 45, 42, 30, 33, 45, 63, 104, 7, 38, 24, 41, 47, 45, 11, 39, 37, 37, 33, 60, 60, 45, 44, 114, 104, 99 }, 72) + (Time.realtimeSinceStartup - _0x3462d4dc).ToString(_0x25b7f0af._0x6b6dc4b7(new byte[5] { 77, 83, 77, 77, 77 }, 125)) + _0x25b7f0af._0x6b6dc4b7(new byte[2] { 171, 248 }, 216) + _0x8217810c);
            if (!firstLoadShown && IsHttpUrl(_0x8217810c))
            {
                firstLoadShown = true;
                _0x26c14ee5 = false;
                _0xabfd088f(false);
                _0x92226804();
                _0xf50d963f();
                _0x3d6a060a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x49278941(_0x25b7f0af._0x6b6dc4b7(new byte[9] { 131, 130, 171, 155, 132, 145, 154, 145, 144 }, 244));
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[39] { 194, 238, 230, 225, 175, 216, 234, 237, 217, 230, 234, 248, 175, 252, 231, 224, 248, 225, 175, 224, 225, 175, 236, 224, 226, 226, 230, 251, 251, 234, 235, 175, 236, 224, 225, 251, 234, 225, 251 }, 143));
            }
        };
        _0x6e6f28cd.OnPageProgressChanged += (_0x3d6a060a, _0x78a70739) =>
        {
            if (_0xe1db808c)
                return;
            if (!firstLoadShown && _0x78a70739 >= 0.65f)
            {
                firstLoadShown = true;
                _0x26c14ee5 = false;
                _0xabfd088f(false);
                _0x92226804();
                _0xf50d963f();
                _0x3d6a060a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x49278941(_0x25b7f0af._0x6b6dc4b7(new byte[9] { 92, 93, 116, 68, 91, 78, 69, 78, 79 }, 43));
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[32] { 169, 133, 141, 138, 196, 179, 129, 134, 178, 141, 129, 147, 196, 151, 140, 139, 147, 138, 196, 134, 157, 196, 148, 150, 139, 131, 150, 129, 151, 151, 222, 196 }, 228) + _0x78a70739);
            }
        };
        _0x6e6f28cd.OnPageFinished += (_0x3d6a060a, _0x96b40265, _0x8217810c) =>
        {
            if (_0xe1db808c && IsAboutBlank(_0x8217810c))
            {
                _0xe1db808c = false;
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[28] { 1, 35, 52, 38, 48, 35, 60, 113, 48, 51, 62, 36, 37, 107, 51, 61, 48, 63, 58, 113, 55, 56, 63, 56, 34, 57, 52, 53 }, 81));
                return;
            }

            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[24] { 181, 153, 145, 150, 216, 175, 157, 154, 174, 145, 157, 143, 216, 190, 145, 150, 145, 139, 144, 157, 156, 194, 216, 211 }, 248) + (Time.realtimeSinceStartup - _0x3462d4dc).ToString(_0x25b7f0af._0x6b6dc4b7(new byte[5] { 98, 124, 98, 98, 98 }, 82)) + _0x25b7f0af._0x6b6dc4b7(new byte[7] { 39, 116, 55, 59, 48, 49, 105 }, 84) + _0x96b40265 + _0x25b7f0af._0x6b6dc4b7(new byte[5] { 160, 245, 242, 236, 189 }, 128) + _0x8217810c);
            if (_0x96b40265 >= 200 && _0x96b40265 < 400)
                MarkMainFrameCommitted(_0x8217810c);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x26c14ee5 = false;
                _0xabfd088f(false);
                _0x92226804();
                _0xf50d963f();
                _0x3d6a060a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x49278941(_0x25b7f0af._0x6b6dc4b7(new byte[9] { 223, 222, 247, 199, 216, 205, 198, 205, 204 }, 168));
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[33] { 239, 195, 203, 204, 130, 245, 199, 192, 244, 203, 199, 213, 130, 196, 203, 208, 209, 214, 130, 206, 205, 195, 198, 130, 193, 205, 207, 210, 206, 199, 214, 199, 198 }, 162));
            }
            else if (_0x26c14ee5)
            {
                _0x26c14ee5 = false;
                _0xabfd088f(false);
                _0x3d6a060a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[40] { 106, 70, 78, 73, 7, 112, 66, 69, 113, 78, 66, 80, 7, 116, 79, 72, 80, 7, 70, 65, 83, 66, 85, 7, 75, 72, 70, 67, 78, 73, 64, 7, 65, 78, 73, 78, 84, 79, 66, 67 }, 39));
            }
            else
            {
                _0xabfd088f(false);
            }

            if (_0x3740f3e1 && !IsGoogleAuthFlowUrl(_0x8217810c) && !IsGoogleAuthFlowUrl(_0x8217810c))
            {
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[48] { 81, 121, 121, 113, 122, 115, 54, 119, 99, 98, 126, 54, 101, 115, 115, 123, 101, 54, 112, 127, 120, 127, 101, 126, 115, 114, 54, 59, 40, 54, 100, 115, 101, 98, 121, 100, 115, 54, 114, 115, 112, 119, 99, 122, 98, 54, 67, 87 }, 22));
                _0x3740f3e1 = false;
                _0xe655ee78.SetUserAgent("");
            }
        };
        _0x6e6f28cd.OnShouldClose += _0x3d6a060a =>
        {
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[41] { 244, 251, 202, 220, 219, 242, 143, 226, 206, 198, 193, 143, 248, 202, 205, 249, 198, 202, 216, 143, 224, 193, 252, 199, 192, 218, 195, 203, 236, 195, 192, 220, 202, 143, 198, 193, 217, 192, 196, 202, 203 }, 175));
            _0x975f1c0f();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x6e6f28cd.SetPopupPageEventEnabled(true);
        bool _0x79d42096 = false;
        bool _0xfb68b86f = false;
        _0x6e6f28cd.OnMultipleWindowOpened += (_0x3d6a060a, _0x2a04d0b4) =>
        {
            _0x3d6a060a.ScrollTo(0, 0, false);
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[43] { 140, 131, 178, 164, 163, 138, 247, 154, 182, 190, 185, 247, 128, 178, 181, 129, 190, 178, 160, 247, 154, 162, 187, 163, 190, 167, 187, 178, 128, 190, 185, 179, 184, 160, 247, 152, 167, 178, 185, 178, 179, 237, 247 }, 215) + _0x2a04d0b4);
            var _0x03b1c44a = _0x6e6f28cd.GetPopupWindow(_0x2a04d0b4);
            if (_0x03b1c44a == null)
                return;
            _0xe8809626.Add(_0x03b1c44a);
            Debug.Log($"[Test] Popup ID: {_0x03b1c44a.Id}");
            _0x03b1c44a.OnPageStarted += (_0x82a9e644, _0x8217810c) =>
            {
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[36] { 97, 110, 95, 73, 78, 103, 26, 106, 85, 74, 79, 74, 26, 109, 95, 88, 108, 83, 95, 77, 26, 117, 84, 106, 91, 93, 95, 105, 78, 91, 72, 78, 95, 94, 0, 26 }, 58) + _0x8217810c);
                _0xac7d9827 = 0;
                if (string.IsNullOrEmpty(_0x8217810c) || IsAboutBlank(_0x8217810c))
                    return;
                if (IsGoogleAuthFlowUrl(_0x8217810c))
                {
                    WLog(_0x25b7f0af._0x6b6dc4b7(new byte[57] { 118, 121, 72, 94, 89, 112, 13, 125, 66, 93, 88, 93, 13, 106, 66, 66, 74, 65, 72, 13, 76, 88, 89, 69, 13, 75, 65, 66, 90, 13, 0, 19, 13, 94, 93, 66, 66, 75, 13, 106, 66, 66, 74, 65, 72, 13, 110, 69, 95, 66, 64, 72, 13, 120, 108, 23, 13 }, 45) + _0x8217810c);
                    _0x79d42096 = false;
                    _0x520dedbb();
                    if (_0x82a9e644 != null && _0x82a9e644.IsAlive)
                        _0x82a9e644.EvaluateJavaScript(_0xbf684d9d());
                    return;
                }

                if (_0xe655ee78 == null)
                    return;
                if (!_0x79d42096)
                {
                    _0x79d42096 = true;
                    _0xe655ee78.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x25b7f0af._0x6b6dc4b7(new byte[39] { 162, 173, 156, 138, 141, 164, 217, 169, 150, 137, 140, 137, 217, 152, 137, 137, 149, 128, 217, 174, 144, 151, 157, 150, 142, 138, 217, 157, 156, 138, 146, 141, 150, 137, 217, 172, 184, 195, 217 }, 249) + _0x8217810c);
                }

                if (_0x82a9e644 != null && _0x82a9e644.IsAlive)
                    _0x82a9e644.EvaluateJavaScript(_0xebb59e3c());
                if (!_0xfb68b86f && _0x82a9e644 != null && _0x82a9e644.IsAlive && IsHttpUrl(_0x8217810c))
                {
                    _0xfb68b86f = true;
                }
            };
            _0x03b1c44a.OnPageFinished += (_0x82a9e644, _0x79e14458) =>
            {
                string _0xb295c3a8 = _0x79e14458 != null ? _0x79e14458.data : string.Empty;
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[35] { 220, 211, 226, 244, 243, 218, 167, 215, 232, 247, 242, 247, 167, 208, 226, 229, 209, 238, 226, 240, 167, 193, 238, 233, 238, 244, 239, 226, 227, 189, 167, 242, 245, 235, 186 }, 135) + _0xb295c3a8);
                if (_0x82a9e644 == null || !_0x82a9e644.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xb295c3a8))
                {
                    _0x520dedbb();
                    _0x82a9e644.EvaluateJavaScript(_0xbf684d9d());
                    return;
                }

                if (!_0x79d42096)
                    return;
                _0x82a9e644.EvaluateJavaScript(_0xebb59e3c());
            };
        };
        _0x6e6f28cd.OnMultipleWindowClosed += (_0x3d6a060a, _0x2a04d0b4) =>
        {
            _0xe8809626.RemoveAll(_0xcd0830ff => _0xcd0830ff == null || _0xcd0830ff.Id == _0x2a04d0b4 || !_0xcd0830ff.IsAlive);
            _0xabfd088f(false);
            if (_0xe8809626.Count == 0 && _0xe655ee78 != null)
            {
                _0x79d42096 = false;
                _0xfb68b86f = false;
                _0x9e148e1f();
            }

            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[43] { 103, 104, 89, 79, 72, 97, 28, 113, 93, 85, 82, 28, 107, 89, 94, 106, 85, 89, 75, 28, 113, 73, 80, 72, 85, 76, 80, 89, 107, 85, 82, 88, 83, 75, 28, 127, 80, 83, 79, 89, 88, 6, 28 }, 60) + _0x2a04d0b4);
        };
        _0x6e6f28cd.RegisterOnRequestMediaCapturePermission(_0x433873fd =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private async void Start()
    {
        await _0x4a18a022();
    }

    private void _0x92226804()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0x603d7dfa(string _0x3b61c97f, string _0xdbcf827e)
    {
        if (string.IsNullOrEmpty(_0xdbcf827e))
            return _0x3b61c97f;
        if (_0x3b61c97f.Contains(_0x25b7f0af._0x6b6dc4b7(new byte[1] { 152 }, 167)))
            return _0x3b61c97f + _0x25b7f0af._0x6b6dc4b7(new byte[8] { 49, 100, 114, 121, 115, 126, 115, 42 }, 23) + UnityWebRequest.EscapeURL(_0xdbcf827e);
        else
            return _0x3b61c97f + _0x25b7f0af._0x6b6dc4b7(new byte[8] { 92, 16, 6, 13, 7, 10, 7, 94 }, 99) + UnityWebRequest.EscapeURL(_0xdbcf827e);
    }

    private string _0x7dfb7bf8 = "";
    private void _0xe11dfbb2(string _0xf59654ca)
    {
        _0x17e2785c();
        StartCoroutine(_0x849797c9(_0xf59654ca));
    }

    internal Rect lastSafe = Rect.zero;
    internal Vector2 lastSize = Vector2.zero;
    private void _0x9e148e1f()
    {
        if (_0xe655ee78 == null)
            return;
        if (_0x3740f3e1)
            _0xe655ee78.SetUserAgent(_0x5fda691d());
        else
            _0xe655ee78.SetUserAgent("");
    }

    internal bool isDestroyedForce = false;
    private bool _0x26c14ee5 = false;
    private void _0xfcc5ddbe()
    {
        {
#if B_LOGS
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[22] { 100, 107, 90, 76, 75, 98, 31, 108, 75, 80, 77, 90, 123, 90, 73, 86, 92, 90, 118, 81, 89, 80 }, 63));
#endif
        }

        _0x27a8e1e3 = SystemInfo.deviceModel;
        _0xf4c23567 = Application.version;
        _0x0fb54c3e = Application.installMode;
        _0xc1da5038 = Application.installerName;
        _0xfdbf7e22 = Application.identifier;
        _0xcddc7c7e = _0xf0bef979();
        _0xf8665526 = _0x01d571af();
        _0x4720dc01 = SystemInfo.deviceUniqueIdentifier;
        _0x1df503e4 = SystemInfo.graphicsDeviceName;
        _0x7dfb7bf8 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0xf4c23567 = _0x25b7f0af._0x6b6dc4b7(new byte[5] { 123, 98, 123, 98, 123 }, 76);
                _0x0fb54c3e = ApplicationInstallMode.Store;
                _0xc1da5038 = _0x25b7f0af._0x6b6dc4b7(new byte[19] { 42, 38, 36, 103, 40, 39, 45, 59, 38, 32, 45, 103, 63, 44, 39, 45, 32, 39, 46 }, 73);
                _0xf8665526 = _0x25b7f0af._0x6b6dc4b7(new byte[8] { 38, 46, 51, 55, 58, 99, 54, 34 }, 67);
                _0x4720dc01 = Guid.NewGuid().ToString().Replace(_0x25b7f0af._0x6b6dc4b7(new byte[1] { 83 }, 126), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[17] { 198, 201, 248, 238, 233, 192, 189, 249, 248, 235, 208, 242, 249, 248, 241, 167, 189 }, 157) + _0x27a8e1e3);
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[19] { 49, 62, 15, 25, 30, 55, 74, 11, 26, 26, 60, 15, 24, 25, 3, 5, 4, 80, 74 }, 106) + _0xf4c23567);
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[20] { 123, 116, 69, 83, 84, 125, 0, 73, 78, 83, 84, 65, 76, 76, 109, 79, 68, 69, 26, 0 }, 32) + _0x0fb54c3e);
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[23] { 101, 106, 91, 77, 74, 99, 30, 87, 80, 77, 74, 95, 82, 82, 91, 76, 109, 74, 81, 76, 91, 4, 30 }, 62) + _0xc1da5038);
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[14] { 37, 42, 27, 13, 10, 35, 94, 31, 14, 14, 55, 26, 68, 94 }, 126) + _0xfdbf7e22);
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[14] { 231, 232, 217, 207, 200, 225, 156, 221, 216, 202, 245, 216, 134, 156 }, 188) + _0xcddc7c7e);
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[18] { 109, 98, 83, 69, 66, 107, 22, 67, 69, 83, 68, 119, 81, 83, 88, 66, 12, 22 }, 54) + _0xf8665526);
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[17] { 182, 185, 136, 158, 153, 176, 205, 158, 148, 158, 169, 136, 155, 164, 137, 215, 205 }, 237) + _0x4720dc01);
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[12] { 118, 121, 72, 94, 89, 112, 13, 74, 93, 88, 23, 13 }, 45) + _0x1df503e4);
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[12] { 225, 238, 223, 201, 206, 231, 154, 217, 202, 207, 128, 154 }, 186) + _0x7dfb7bf8);
#endif
        }
    }

    private bool _0x159287c6(string _0x06361f17)
    {
        string _0x2c010d39 = GetUrlHost(_0x06361f17);
        if (!string.IsNullOrEmpty(_0x2c010d39) && !string.IsNullOrEmpty(_0xbe385f1d) && !string.Equals(_0x2c010d39, _0xbe385f1d, StringComparison.OrdinalIgnoreCase))
            return true;
        return _0x5811e630;
    }

    private string GetUrlHost(string _0x31940892)
    {
        if (string.IsNullOrEmpty(_0x31940892))
            return null;
        Uri _0xb00bbcfc;
        if (!Uri.TryCreate(_0x31940892, UriKind.Absolute, out _0xb00bbcfc))
            return null;
        string _0xba4d62d5 = _0xb00bbcfc.Host;
        if (_0xba4d62d5.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[4] { 205, 205, 205, 148 }, 186), StringComparison.OrdinalIgnoreCase))
            _0xba4d62d5 = _0xba4d62d5.Substring(4);
        return _0xba4d62d5;
    }

    private string _0xa2305d51;
    private bool _0x3858b976 = false;
    private async Task _0x024fc85e()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xa5ab96a4 = _0x25b7f0af._0x6b6dc4b7(new byte[5] { 149, 146, 159, 128, 150 }, 243);
        _0x6de28b5d = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xb81a319e = DateTime.UtcNow.Ticks.ToString();
        _0x09d8212a = "";
        JObject _0xcf3fe9f6 = _0x4bdba1c7(_0xfdbf7e22, _0xcddc7c7e, _0x9d809bf8, _0xcb7d8c73, _0x7e6f24ee, _0x5ddebf5e, _0xf8665526, _0xbff068ef, _0x4720dc01, _0xa5ab96a4, _0x27a8e1e3, _0xf4c23567, _0x0fb54c3e.ToString(), _0xc1da5038, _0xb81a319e, _0xf05bb907, _0x1df503e4, _0x7dfb7bf8, _0xa874124f, _0x4e99c389());
        var _0x148fb8ea = _0x47c612b6(_0xcf3fe9f6.ToString(), _0xf05bb907);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xcf3fe9f6}");
            }
#endif
        }

        try
        {
            await _0x2b4a38f4(LeaderboardId, 1d, _0x148fb8ea);
            await Task.Delay(500);
            string _0x8c3d511a = "";
            for (int _0x72fb189d = 0; _0x72fb189d < 20; _0x72fb189d++)
            {
                if (await _0x6c654759(1, 1))
                {
                    await _0x49278941(_0x25b7f0af._0x6b6dc4b7(new byte[7] { 2, 12, 15, 3, 11, 5, 4 }, 96));
                    _0xc2c27d41();
                    return;
                }

                _0x8c3d511a = await _0x738747f0(1, 500);
                if (!string.IsNullOrEmpty(_0x8c3d511a))
                    break;
            }

            _0x535bf0b8(_0x8c3d511a);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[22] { 15, 0, 17, 7, 0, 9, 116, 19, 49, 58, 49, 38, 53, 56, 116, 49, 38, 38, 59, 38, 110, 116 }, 84) + e.Message);
#endif
            }

            _0xc2c27d41();
        }
    }

    private bool _0x82385490(string _0xca86af01)
    {
        try
        {
            using (var _0x5d51e8db = new AndroidJavaClass(_0x25b7f0af._0x6b6dc4b7(new byte[30] { 240, 252, 254, 189, 230, 253, 250, 231, 234, 160, 247, 189, 227, 255, 242, 234, 246, 225, 189, 198, 253, 250, 231, 234, 195, 255, 242, 234, 246, 225 }, 147)))
            using (var _0x11f7f34e = _0x5d51e8db.GetStatic<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[15] { 77, 91, 92, 92, 75, 64, 90, 111, 77, 90, 71, 88, 71, 90, 87 }, 46)))
            using (var _0x7e46f50a = new AndroidJavaClass(_0x25b7f0af._0x6b6dc4b7(new byte[15] { 48, 63, 53, 35, 62, 56, 53, 127, 63, 52, 37, 127, 4, 35, 56 }, 81)))
            using (var _0x209082d9 = _0x7e46f50a.CallStatic<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[5] { 168, 185, 170, 171, 189 }, 216), _0xca86af01))
            using (var _0xe3cb9179 = new AndroidJavaObject(_0x25b7f0af._0x6b6dc4b7(new byte[22] { 30, 17, 27, 13, 16, 22, 27, 81, 28, 16, 17, 11, 26, 17, 11, 81, 54, 17, 11, 26, 17, 11 }, 127), _0x25b7f0af._0x6b6dc4b7(new byte[26] { 107, 100, 110, 120, 101, 99, 110, 36, 99, 100, 126, 111, 100, 126, 36, 107, 105, 126, 99, 101, 100, 36, 92, 67, 79, 93 }, 10), _0x209082d9))
            {
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[26] { 59, 16, 10, 23, 21, 29, 52, 17, 19, 29, 88, 23, 8, 29, 22, 88, 29, 0, 12, 29, 10, 22, 25, 20, 66, 88 }, 120) + _0xca86af01);
                _0xe3cb9179.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[11] { 48, 53, 53, 18, 48, 37, 52, 54, 62, 35, 40 }, 81), _0x25b7f0af._0x6b6dc4b7(new byte[33] { 63, 48, 58, 44, 49, 55, 58, 112, 55, 48, 42, 59, 48, 42, 112, 61, 63, 42, 59, 57, 49, 44, 39, 112, 28, 12, 17, 9, 13, 31, 28, 18, 27 }, 94));
                _0xe3cb9179.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[8] { 207, 202, 202, 232, 194, 207, 201, 221 }, 174), 0x10000000);
                _0x11f7f34e.Call(_0x25b7f0af._0x6b6dc4b7(new byte[13] { 179, 180, 161, 178, 180, 129, 163, 180, 169, 182, 169, 180, 185 }, 192), _0xe3cb9179);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[28] { 2, 41, 51, 46, 44, 36, 13, 40, 42, 36, 97, 36, 57, 53, 36, 51, 47, 32, 45, 97, 39, 32, 40, 45, 36, 37, 123, 97 }, 65) + e.Message);
            Application.OpenURL(_0xca86af01);
            return true;
        }
    }

    private string _0xc1da5038 = "";
    private readonly string[] _0x9329fbbf = new string[]
    {
        _0x25b7f0af._0x6b6dc4b7(new byte[60] { 193, 174, 191, 129, 17, 101, 89, 84, 17, 67, 84, 84, 93, 66, 17, 80, 67, 84, 17, 89, 94, 69, 17, 67, 88, 86, 89, 69, 17, 95, 94, 70, 17, 211, 177, 162, 17, 85, 94, 95, 211, 177, 168, 69, 17, 92, 88, 66, 66, 17, 72, 94, 68, 67, 17, 66, 65, 88, 95, 16 }, 49),
        _0x25b7f0af._0x6b6dc4b7(new byte[52] { 45, 66, 80, 93, 253, 148, 169, 253, 190, 178, 168, 177, 185, 253, 191, 184, 253, 164, 178, 168, 175, 253, 177, 168, 190, 182, 164, 253, 176, 178, 176, 184, 179, 169, 253, 63, 93, 78, 253, 170, 181, 164, 253, 174, 169, 178, 173, 253, 179, 178, 170, 226 }, 221),
        _0x25b7f0af._0x6b6dc4b7(new byte[66] { 206, 182, 141, 195, 148, 163, 12, 110, 69, 75, 12, 91, 69, 66, 95, 12, 77, 94, 73, 12, 68, 69, 88, 88, 69, 66, 75, 12, 65, 67, 94, 73, 12, 67, 74, 88, 73, 66, 12, 88, 67, 72, 77, 85, 12, 206, 172, 191, 12, 95, 88, 77, 85, 12, 69, 66, 12, 88, 68, 73, 12, 75, 77, 65, 73, 2 }, 44),
        _0x25b7f0af._0x6b6dc4b7(new byte[54] { 27, 116, 126, 121, 203, 191, 131, 130, 152, 203, 130, 152, 203, 155, 153, 130, 134, 142, 203, 159, 130, 134, 142, 203, 9, 107, 120, 203, 159, 131, 142, 203, 137, 142, 152, 159, 203, 155, 135, 138, 146, 142, 153, 152, 203, 155, 135, 138, 146, 203, 133, 132, 156, 197 }, 235),
        _0x25b7f0af._0x6b6dc4b7(new byte[48] { 104, 7, 12, 61, 184, 193, 247, 237, 234, 184, 239, 241, 246, 246, 241, 246, 255, 184, 235, 236, 234, 253, 249, 243, 184, 251, 247, 237, 244, 252, 184, 250, 253, 184, 247, 246, 253, 184, 235, 232, 241, 246, 184, 249, 239, 249, 225, 182 }, 152),
        _0x25b7f0af._0x6b6dc4b7(new byte[65] { 248, 151, 146, 136, 40, 66, 105, 107, 99, 120, 103, 124, 123, 40, 105, 122, 109, 40, 101, 103, 122, 109, 40, 105, 107, 124, 97, 126, 109, 40, 124, 103, 102, 97, 111, 96, 124, 40, 234, 136, 155, 40, 123, 124, 105, 113, 40, 105, 102, 108, 40, 124, 122, 113, 40, 113, 103, 125, 122, 40, 100, 125, 107, 99, 38 }, 8),
        _0x25b7f0af._0x6b6dc4b7(new byte[55] { 70, 41, 56, 4, 150, 243, 192, 211, 196, 207, 150, 197, 198, 223, 216, 150, 213, 217, 195, 216, 194, 197, 150, 84, 54, 37, 150, 194, 222, 211, 150, 216, 211, 206, 194, 150, 217, 216, 211, 150, 213, 217, 195, 218, 210, 150, 212, 211, 150, 207, 217, 195, 196, 197, 152 }, 182),
        _0x25b7f0af._0x6b6dc4b7(new byte[63] { 49, 126, 67, 60, 107, 92, 243, 131, 191, 178, 170, 182, 161, 160, 243, 161, 186, 180, 187, 167, 243, 189, 188, 164, 243, 178, 161, 182, 243, 164, 186, 189, 189, 186, 189, 180, 243, 49, 83, 64, 243, 183, 188, 189, 49, 83, 74, 167, 243, 164, 178, 191, 184, 243, 178, 164, 178, 170, 243, 170, 182, 167, 253 }, 211),
        _0x25b7f0af._0x6b6dc4b7(new byte[51] { 69, 42, 58, 51, 149, 250, 219, 217, 204, 149, 193, 221, 218, 198, 208, 149, 194, 221, 218, 149, 198, 193, 212, 204, 149, 220, 219, 149, 193, 221, 208, 149, 210, 212, 216, 208, 149, 194, 220, 219, 149, 193, 221, 208, 149, 197, 199, 220, 207, 208, 155 }, 181),
        _0x25b7f0af._0x6b6dc4b7(new byte[64] { 245, 141, 182, 248, 175, 152, 55, 90, 120, 122, 114, 121, 99, 98, 122, 55, 126, 100, 55, 114, 97, 114, 101, 110, 99, 127, 126, 121, 112, 55, 245, 151, 132, 55, 124, 114, 114, 103, 55, 100, 103, 126, 121, 121, 126, 121, 112, 55, 113, 120, 101, 55, 110, 120, 98, 101, 55, 116, 127, 118, 121, 116, 114, 57 }, 23)
    };
    private float _0x3462d4dc = 0f;
    private void MarkMainFrameCommitted(string _0xb5df0940)
    {
        _0x5811e630 = true;
        string _0x83e9d135 = GetUrlHost(_0xb5df0940);
        if (!string.IsNullOrEmpty(_0x83e9d135))
            _0xbe385f1d = _0x83e9d135;
    }

    private Canvas _0xe04d48fc()
    {
        if (_0xff020591 != null)
            return _0xff020591;
        var _0x59267c3a = gameObject.GetComponentInChildren<Canvas>();
        if (_0x59267c3a == null)
        {
            var _0x51b7594c = new GameObject(_0x25b7f0af._0x6b6dc4b7(new byte[6] { 203, 233, 230, 254, 233, 251 }, 136), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x59267c3a = _0x51b7594c.GetComponent<Canvas>();
            _0x59267c3a.transform.SetParent(transform, false);
            _0x59267c3a.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xff020591 = _0x59267c3a;
        return _0xff020591;
    }

    private void _0x01427e1b(string _0xa85aa674)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[34] { 63, 48, 1, 23, 16, 57, 68, 34, 1, 16, 7, 12, 68, 33, 28, 16, 22, 5, 68, 52, 17, 23, 12, 68, 32, 5, 16, 5, 68, 54, 5, 19, 94, 68 }, 100) + _0xa85aa674);
#endif
            }
        }

        var _0x4cf94109 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xa85aa674);
        StartCoroutine(_0x8fda128b(_0x4cf94109));
    }

    private string _0x9d809bf8 = "";
    private async Task<bool> _0xfe19342e()
    {
        _0x59a05dda.Instance?._0xd789eee8();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x20fa8434) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[32] { 252, 243, 194, 212, 211, 250, 135, 242, 201, 206, 211, 222, 135, 247, 210, 212, 207, 135, 233, 200, 211, 206, 193, 206, 196, 198, 211, 206, 200, 201, 157, 135 }, 167) + string.Join(_0x25b7f0af._0x6b6dc4b7(new byte[1] { 80 }, 89), _0x20fa8434));
                }
#endif
            }
        };
        try
        {
            _0x9d809bf8 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[31] { 33, 46, 31, 9, 14, 39, 90, 60, 27, 19, 22, 31, 30, 90, 14, 21, 90, 29, 31, 14, 90, 10, 15, 9, 18, 90, 14, 21, 17, 31, 20 }, 122));
                }
#endif
            }

            _0x9d809bf8 = "";
        }

        _0x3858b976 = !string.IsNullOrEmpty(_0x9d809bf8);
        _0xa874124f = _0x4e99c389();
        {
#if B_LOGS
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[25] { 179, 188, 141, 155, 156, 181, 200, 189, 134, 129, 156, 145, 200, 184, 157, 155, 128, 200, 188, 135, 131, 141, 134, 210, 200 }, 232) + _0x9d809bf8);
#endif
        }

        _0x59a05dda.Instance?._0xddbb75e6();
        return false;
    }

    private async Task<bool> _0x6c654759(int _0x855b6f30 = 5, int _0x2e9a8391 = 500)
    {
        CommState _0xbd364bdb = default;
        int _0xc0e5c2f7 = 0;
        do
        {
            try
            {
                _0xbd364bdb = await _0xb4aed4e4();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[32] { 86, 89, 104, 126, 121, 80, 45, 124, 120, 104, 127, 116, 76, 126, 116, 99, 110, 95, 104, 126, 120, 97, 121, 126, 45, 104, 127, 127, 98, 127, 55, 45 }, 13) + e.Message);
                    }
#endif
                }
            }

            if (_0xbd364bdb.Ready)
                break;
            await Task.Delay(_0x2e9a8391);
        }
        while (_0xc0e5c2f7++ < _0x855b6f30);
        bool _0x03729a1b = _0xbd364bdb.Ready && _0xbd364bdb.IsPrivacy;
        {
#if B_LOGS
            {
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[25] { 41, 38, 23, 1, 6, 47, 82, 59, 1, 34, 0, 27, 4, 19, 17, 11, 82, 0, 23, 1, 7, 30, 6, 72, 82 }, 114) + _0x03729a1b);
            }
#endif
        }

        return _0x03729a1b;
    }

    private Action _0x053355b2;
    private bool _0xd3419975(string _0x7b22030f, string _0x4aa55247)
    {
        string _0x5d01e6c7 = _0xa3746deb(_0x7b22030f);
        if (string.IsNullOrEmpty(_0x5d01e6c7))
            _0x5d01e6c7 = _0x4aa55247;
        if (_0x73a72086(_0x5d01e6c7))
            return true;
        string _0xe7d152f2 = string.IsNullOrEmpty(_0x5d01e6c7) ? _0x25b7f0af._0x6b6dc4b7(new byte[29] { 87, 75, 75, 79, 76, 5, 16, 16, 79, 83, 94, 70, 17, 88, 80, 80, 88, 83, 90, 17, 92, 80, 82, 16, 76, 75, 80, 77, 90 }, 63) : _0x25b7f0af._0x6b6dc4b7(new byte[46] { 250, 230, 230, 226, 225, 168, 189, 189, 226, 254, 243, 235, 188, 245, 253, 253, 245, 254, 247, 188, 241, 253, 255, 189, 225, 230, 253, 224, 247, 189, 243, 226, 226, 225, 189, 246, 247, 230, 243, 251, 254, 225, 173, 251, 246, 175 }, 146) + _0x5d01e6c7;
        WLog(_0x25b7f0af._0x6b6dc4b7(new byte[35] { 152, 179, 169, 180, 182, 190, 151, 178, 176, 190, 251, 182, 186, 169, 176, 190, 175, 251, 189, 186, 183, 183, 185, 186, 184, 176, 251, 186, 168, 251, 172, 190, 185, 225, 251 }, 219) + _0xe7d152f2);
        return _0x82385490(_0xe7d152f2);
    }

    // WS_SOURCE MONO
    public static _0x9cbda3d8 _0x737a8a6e { get; private set; }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0xe655ee78 = null;
    private string _0x7e6f24ee { get; set; }

    private string _0xa874124f = "";
    private void _0x17e2785c()
    {
        using (var _0xef37700a = new AndroidJavaClass(_0x25b7f0af._0x6b6dc4b7(new byte[30] { 55, 59, 57, 122, 33, 58, 61, 32, 45, 103, 48, 122, 36, 56, 53, 45, 49, 38, 122, 1, 58, 61, 32, 45, 4, 56, 53, 45, 49, 38 }, 84)))
        using (var _0xa3110762 = _0xef37700a.GetStatic<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[15] { 224, 246, 241, 241, 230, 237, 247, 194, 224, 247, 234, 245, 234, 247, 250 }, 131)))
        using (var _0xaa28dd03 = _0xa3110762.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[9] { 81, 83, 66, 127, 88, 66, 83, 88, 66 }, 54)))
        {
            if (_0xaa28dd03 == null)
                return;
            using (var _0x427ef5a1 = _0xaa28dd03.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[9] { 139, 137, 152, 169, 148, 152, 158, 141, 159 }, 236)))
            {
                if (_0x427ef5a1 == null)
                    return;
                using (var _0x9b1c3b3e = new AndroidJavaObject(_0x25b7f0af._0x6b6dc4b7(new byte[19] { 28, 1, 20, 93, 25, 0, 28, 29, 93, 57, 32, 60, 61, 60, 17, 25, 22, 16, 7 }, 115)))
                using (var _0x41808bc4 = _0x427ef5a1.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[6] { 162, 172, 176, 154, 172, 189 }, 201)))
                using (var _0xa4160689 = _0x41808bc4.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[8] { 80, 77, 92, 75, 88, 77, 86, 75 }, 57)))
                {
                    while (_0xa4160689.Call<bool>(_0x25b7f0af._0x6b6dc4b7(new byte[7] { 111, 102, 116, 73, 98, 127, 115 }, 7)))
                    {
                        string _0x9aef3c4d = _0xa4160689.Call<string>(_0x25b7f0af._0x6b6dc4b7(new byte[4] { 35, 40, 53, 57 }, 77));
                        using (var _0x2a1ff499 = _0x427ef5a1.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[3] { 107, 105, 120 }, 12), _0x9aef3c4d))
                        {
                            _0x9b1c3b3e.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[3] { 0, 5, 4 }, 112), _0x9aef3c4d, _0x2a1ff499);
                        }
                    }

                    string _0x1de60952 = _0x9b1c3b3e.Call<string>(_0x25b7f0af._0x6b6dc4b7(new byte[8] { 9, 18, 46, 9, 15, 20, 19, 26 }, 125));
                    if (!string.IsNullOrEmpty(_0x1de60952))
                    {
                        _0xb200285b(_0x1de60952);
                        _0x01427e1b(_0x1de60952);
                    }
                }
            }
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0xddceeeab)
    {
        _0xabfd088f(false);
        if (_0xddceeeab == null)
            return;
        _0xddceeeab.Stop();
        if (_0xddceeeab.CanGoBack)
            _0xddceeeab.GoBack();
    }

    private IEnumerator _0xce2a53d6()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[26] { 102, 105, 88, 78, 73, 96, 29, 116, 83, 84, 73, 84, 92, 81, 84, 71, 88, 111, 88, 91, 91, 88, 79, 88, 79, 29 }, 61));
            }
#endif
        }

        bool _0xdbaa79e9 = false;
        InstallReferrer.GetReferrer((_0x4c25e5be) =>
        {
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[24] { 208, 223, 238, 248, 255, 171, 217, 238, 237, 238, 249, 249, 238, 249, 214, 171, 236, 238, 255, 171, 105, 13, 25, 171 }, 139) + _0xcb7d8c73);
            if (_0x4c25e5be.IsSuccess)
            {
                _0xcb7d8c73 = _0x4c25e5be.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[28] { 12, 3, 50, 36, 35, 119, 5, 50, 49, 50, 37, 37, 50, 37, 10, 119, 4, 34, 52, 52, 50, 36, 36, 119, 181, 209, 197, 119 }, 87) + _0xcb7d8c73);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[27] { 154, 149, 164, 178, 181, 225, 147, 164, 167, 164, 179, 179, 164, 179, 156, 225, 135, 160, 168, 173, 164, 165, 225, 35, 71, 83, 225 }, 193) + _0x4c25e5be);
#endif
                }

                _0xcb7d8c73 = "";
            }

            _0x729876e9 = true;
        });
        StartCoroutine(_0x2c29c6f1(2f));
        yield return new WaitUntil(() => _0x729876e9);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xcb7d8c73}");
#endif
        }

        bool _0x099c2c84 = _0xcb7d8c73.Contains(_0x25b7f0af._0x6b6dc4b7(new byte[6] { 38, 34, 45, 40, 37, 124 }, 65));
        _0xdbaa79e9 = _0x099c2c84 || _0xcb7d8c73.Contains(_0x25b7f0af._0x6b6dc4b7(new byte[18] { 67, 82, 82, 81, 12, 75, 76, 81, 86, 67, 69, 80, 67, 79, 12, 65, 77, 79 }, 34)) || _0xcb7d8c73.Contains(_0x25b7f0af._0x6b6dc4b7(new byte[17] { 211, 194, 194, 193, 156, 212, 211, 209, 215, 208, 221, 221, 217, 156, 209, 221, 223 }, 178));
        _0x7e6f24ee = _0x099c2c84 ? "" : (_0xdbaa79e9 ? "" : _0x7e6f24ee);
        _0x7e6f24ee = _0x7e6f24ee ?? "";
        _0x5ddebf5e = _0x5ddebf5e ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x7e6f24ee}");
#endif
        }
    }

    private string _0x27a8e1e3 = "";
    private string _0xf05bb907 = "";
    private string _0xf4c23567 = "";
    private bool _0x5811e630;
    private GameObject _0x805495c8;
    private bool _0x364481ec = false;
    private bool IsSslError(int _0x84b32503, string _0x8dd132ae)
    {
        if (_0x84b32503 == -1202 || _0x84b32503 == -1200 || _0x84b32503 == -11 || _0x84b32503 == -202)
            return true;
        if (string.IsNullOrEmpty(_0x8dd132ae))
            return false;
        return _0x8dd132ae.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[3] { 110, 110, 113 }, 61), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8dd132ae.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[11] { 232, 238, 249, 255, 226, 237, 226, 232, 234, 255, 238 }, 139), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8dd132ae.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[4] { 222, 216, 207, 201 }, 157), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    // MAIN FLOW
    private bool _0x729876e9 { get; set; }

    private bool _0x73a72086(string _0x0f009b96)
    {
        if (string.IsNullOrEmpty(_0x0f009b96))
            return false;
        try
        {
            using (var _0x8764201a = new AndroidJavaClass(_0x25b7f0af._0x6b6dc4b7(new byte[30] { 31, 19, 17, 82, 9, 18, 21, 8, 5, 79, 24, 82, 12, 16, 29, 5, 25, 14, 82, 41, 18, 21, 8, 5, 44, 16, 29, 5, 25, 14 }, 124)))
            using (var _0x85f2f84c = _0x8764201a.GetStatic<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[15] { 199, 209, 214, 214, 193, 202, 208, 229, 199, 208, 205, 210, 205, 208, 221 }, 164)))
            using (var _0x517b17ff = _0x85f2f84c.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[17] { 139, 137, 152, 188, 141, 143, 135, 141, 139, 137, 161, 141, 130, 141, 139, 137, 158 }, 236)))
            using (var _0xf4a8f58b = _0x517b17ff.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[25] { 86, 84, 69, 125, 80, 68, 95, 82, 89, 120, 95, 69, 84, 95, 69, 119, 94, 67, 97, 80, 82, 90, 80, 86, 84 }, 49), _0x0f009b96))
            {
                if (_0xf4a8f58b == null)
                    return false;
                WLog(_0x25b7f0af._0x6b6dc4b7(new byte[37] { 101, 78, 84, 73, 75, 67, 106, 79, 77, 67, 6, 74, 71, 83, 72, 69, 78, 6, 79, 72, 85, 82, 71, 74, 74, 67, 66, 6, 86, 71, 69, 77, 71, 65, 67, 28, 6 }, 38) + _0x0f009b96);
                _0xf4a8f58b.Call<AndroidJavaObject>(_0x25b7f0af._0x6b6dc4b7(new byte[8] { 239, 234, 234, 200, 226, 239, 233, 253 }, 142), 0x10000000);
                _0x85f2f84c.Call(_0x25b7f0af._0x6b6dc4b7(new byte[13] { 253, 250, 239, 252, 250, 207, 237, 250, 231, 248, 231, 250, 247 }, 142), _0xf4a8f58b);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private int _0xbdce9561 = 5, _0x8e45f863 = 5, _0x78d90e4f = 5, _0x2f7de547 = 5;
    private string _0x8e6f2d7d = "";
    private IEnumerator _0x849797c9(string _0xcf4613e0)
    {
        if (_0xe655ee78 != null && _0x01e632f1)
            yield break;
        _0xe655ee78 = gameObject.AddComponent<UniWebView>();
        _0x8f4ab4af(_0xe655ee78);
        _0x1ea28887(_0xe655ee78);
        _0xe655ee78.BackgroundColor = Color.clear;
        var _0xf427dc50 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xf50d963f();
        yield return new WaitForEndOfFrame();
        _0x01e632f1 = true;
        _0xd2b91db5();
        _0xabfd088f(true);
        _0xe1db808c = false;
        _0x3740f3e1 = false;
        _0xe8809626.Clear();
        _0x2d975591 = -1;
        firstLoadShown = false;
        _0x26c14ee5 = false;
        _0xa83c000a = false;
        _0xe655ee78.SetUserAgent("");
        _0x3462d4dc = Time.realtimeSinceStartup;
        _0xe655ee78.Stop();
        _0xe655ee78.Load(_0xcf4613e0);
        _0xe655ee78.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x25b7f0af._0x6b6dc4b7(new byte[25] { 9, 37, 45, 42, 100, 19, 33, 38, 18, 45, 33, 51, 100, 13, 42, 45, 48, 45, 37, 40, 100, 23, 44, 43, 51 }, 68));
    }

    internal bool isApplicationPause = false;
    private async Task _0x4a18a022()
    {
        if (await _0x87f5089e())
            return;
        if (await _0xfe19342e())
            return;
        if (await _0xabecfd18())
            return;
        _0xfcc5ddbe();
        await _0x5f9ec52e(_0xce2a53d6());
        _0xbff068ef = await _0x244b2ad2();
        await _0x024fc85e();
    }

    private string _0xfdbf7e22 = "";
    private IEnumerator _0xc2a368a4()
    {
        yield return _0xb908b124(Permission.Camera);
    }

    private string _0xd1408c27()
    {
        return ((char)('a' + _0x57340fec.Next(0, 26))).ToString();
    }

    static byte[] DecompressBrotli(byte[] _0xe232afe9)
    {
        using var _0xe0e8ea46 = new MemoryStream(_0xe232afe9);
        using var _0xe7c90832 = new BrotliStream(_0xe0e8ea46, CompressionMode.Decompress);
        using var _0xcd496ba7 = new MemoryStream();
        _0xe7c90832.CopyTo(_0xcd496ba7);
        return _0xcd496ba7.ToArray();
    }

    private async Task<bool> _0xabecfd18()
    {
        {
#if B_LOGS
            Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[29] { 176, 191, 142, 152, 159, 182, 203, 162, 152, 187, 153, 130, 157, 138, 136, 146, 170, 133, 143, 184, 138, 157, 142, 143, 168, 131, 142, 136, 128 }, 235));
#endif
        }

        string _0x3480437e = "";
        for (int _0x0c26b6a1 = 0; _0x0c26b6a1 < 2; _0x0c26b6a1++)
        {
            if (await _0x6c654759(1, 100))
            {
                await _0x49278941(_0x25b7f0af._0x6b6dc4b7(new byte[7] { 18, 28, 31, 19, 27, 21, 20 }, 112));
                _0xc2c27d41();
                return true;
            }

            _0x3480437e = await _0x738747f0(1, 100);
            if (!string.IsNullOrEmpty(_0x3480437e))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x3480437e))
            {
                if (!string.IsNullOrEmpty(_0xfd1ef4ad))
                {
                    _0x3480437e = _0x603d7dfa(_0x3480437e, _0xfd1ef4ad);
                    {
#if B_LOGS
                        Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[53] { 117, 122, 75, 93, 90, 115, 14, 109, 79, 77, 70, 75, 74, 14, 72, 71, 64, 79, 66, 123, 92, 66, 14, 89, 71, 90, 70, 14, 93, 75, 64, 74, 71, 74, 14, 204, 168, 188, 14, 93, 70, 65, 89, 14, 121, 75, 76, 120, 71, 75, 89, 20, 14 }, 46) + _0x3480437e);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[39] { 62, 49, 0, 22, 17, 56, 69, 38, 4, 6, 13, 0, 1, 69, 3, 12, 11, 4, 9, 48, 23, 9, 69, 135, 227, 247, 69, 22, 13, 10, 18, 69, 50, 0, 7, 51, 12, 0, 18 }, 101));
#endif
                    }
                }

                _0x55a0ea70 = true;
                _0xe11dfbb2(_0x3480437e);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[44] { 128, 143, 190, 168, 175, 134, 251, 158, 163, 184, 190, 171, 175, 178, 180, 181, 251, 172, 179, 178, 183, 190, 251, 184, 179, 190, 184, 176, 178, 181, 188, 251, 168, 186, 173, 190, 191, 251, 183, 178, 181, 176, 225, 251 }, 219) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private string _0xfd1ef4ad;
    private void _0x975f1c0f()
    {
        WLog(_0x25b7f0af._0x6b6dc4b7(new byte[21] { 18, 59, 40, 62, 45, 59, 40, 63, 122, 56, 59, 57, 49, 122, 42, 40, 63, 41, 41, 63, 62 }, 90));
        if (Time.frameCount == _0x2d975591)
            return;
        _0x2d975591 = Time.frameCount;
        if (_0x037298de())
            return;
        _0xcc0e11ec();
    }

    internal void _0xf50d963f()
    {
        Rect _0xd0798e94 = Screen.safeArea;
        Vector2 _0x045a3c90 = new Vector2(Screen.width, Screen.height);
        if (_0xd0798e94 == lastSafe && _0x045a3c90 == lastSize)
            return;
        // Apply manual padding
        _0xd0798e94.xMin += _0x78d90e4f;
        _0xd0798e94.xMax -= _0x2f7de547;
        _0xd0798e94.yMin += _0x8e45f863;
        _0xd0798e94.yMax -= _0xbdce9561;
        // Convert Unity safe area -> native WebView frame
        Rect _0x5e916e4f = new Rect(_0xd0798e94.x, _0x045a3c90.y - _0xd0798e94.y - _0xd0798e94.height, // Y flip for native coordinate system
 _0xd0798e94.width, _0xd0798e94.height);
        _0xe655ee78.Frame = _0x5e916e4f;
        lastSafe = Screen.safeArea;
        lastSize = _0x045a3c90;
    }

    static byte[] AesCtr(byte[] _0x50a61316, byte[] _0xea1f6ffc, byte[] _0x413e6b3e)
    {
        using var _0xc9c3ba70 = Aes.Create();
        _0xc9c3ba70.Mode = CipherMode.ECB;
        _0xc9c3ba70.Padding = PaddingMode.None;
        _0xc9c3ba70.Key = _0xea1f6ffc;
        using var _0x58485d87 = _0xc9c3ba70.CreateEncryptor();
        var _0x2e64e23e = new byte[_0x50a61316.Length];
        var _0x5817ff03 = new byte[16];
        var _0x7632074e = new byte[16];
        Buffer.BlockCopy(_0x413e6b3e, 0, _0x5817ff03, 0, 4);
        int _0xca385110 = 0;
        while (_0xca385110 < _0x50a61316.Length)
        {
            if (_0x58485d87.TransformBlock(_0x5817ff03, 0, 16, _0x7632074e, 0) != 16)
                throw new CryptographicException();
            int n = Math.Min(16, _0x50a61316.Length - _0xca385110);
            for (int _0xf97c3ab0 = 0; _0xf97c3ab0 < n; _0xf97c3ab0++)
                _0x2e64e23e[_0xca385110 + _0xf97c3ab0] = (byte)(_0x50a61316[_0xca385110 + _0xf97c3ab0] ^ _0x7632074e[_0xf97c3ab0]);
            for (int _0x2aa85f15 = _0x5817ff03.Length - 1; _0x2aa85f15 >= 4; _0x2aa85f15--)
            {
                _0x5817ff03[_0x2aa85f15]++;
                if (_0x5817ff03[_0x2aa85f15] != 0)
                    break;
            }

            _0xca385110 += n;
        }

        return _0x2e64e23e;
    }

    internal string _0xa3746deb(string _0x3d429c05)
    {
        int _0x030d4022 = _0x3d429c05.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[3] { 156, 145, 200 }, 245), StringComparison.OrdinalIgnoreCase);
        if (_0x030d4022 < 0)
            return null;
        string _0x1ec8c26a = _0x3d429c05.Substring(_0x030d4022 + 3);
        int _0x773f071a = _0x1ec8c26a.IndexOf('&');
        return _0x773f071a >= 0 ? _0x1ec8c26a.Substring(0, _0x773f071a) : _0x1ec8c26a;
    }

    internal bool IsGoogleAuthFlowUrl(string _0xf4d9c28e)
    {
        if (string.IsNullOrEmpty(_0xf4d9c28e))
            return false;
        return _0xf4d9c28e.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[19] { 156, 158, 158, 146, 136, 147, 137, 142, 211, 154, 146, 146, 154, 145, 152, 211, 158, 146, 144 }, 253), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf4d9c28e.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[16] { 71, 69, 69, 73, 83, 72, 82, 85, 8, 65, 73, 73, 65, 74, 67, 8 }, 38), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf4d9c28e.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[21] { 89, 81, 81, 89, 82, 91, 75, 77, 91, 76, 93, 81, 80, 74, 91, 80, 74, 16, 93, 81, 83 }, 62), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf4d9c28e.IndexOf(_0x25b7f0af._0x6b6dc4b7(new byte[11] { 26, 14, 9, 28, 9, 20, 30, 83, 30, 18, 16 }, 125), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xf8665526 = "";
    private void _0x520dedbb()
    {
        _0x3740f3e1 = true;
        if (_0xe655ee78 != null)
            _0xe655ee78.SetUserAgent(_0x5fda691d());
    }

    private string _0x47c612b6(string _0x31331612, string _0xeba81fd4)
    {
        try
        {
            var _0x48d80685 = Encoding.UTF8.GetBytes(_0x31331612 ?? "");
            var _0x2c436b2c = PackSmallest(_0x48d80685, out var mode);
            var _0x0889d305 = new byte[4];
            using (var _0xb99d6fff = RandomNumberGenerator.Create())
                _0xb99d6fff.GetBytes(_0x0889d305);
            var _0x22c2ecf7 = new byte[1 + _0x2c436b2c.Length];
            _0x22c2ecf7[0] = mode;
            Buffer.BlockCopy(_0x2c436b2c, 0, _0x22c2ecf7, 1, _0x2c436b2c.Length);
            var _0x38afb75b = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xeba81fd4 ?? ""));
            var _0x28130dfa = AesCtr(_0x22c2ecf7, _0x38afb75b, _0x0889d305);
            var _0x1371639e = new byte[_0x0889d305.Length + _0x28130dfa.Length];
            Buffer.BlockCopy(_0x0889d305, 0, _0x1371639e, 0, _0x0889d305.Length);
            Buffer.BlockCopy(_0x28130dfa, 0, _0x1371639e, _0x0889d305.Length, _0x28130dfa.Length);
            return Encode93(_0x1371639e);
        }
        catch (Exception)
        {
            return "";
        }
    }

    private bool _0x3740f3e1 = false;
    static byte[] DecompressDeflate(byte[] _0x9af64ecc)
    {
        using var _0x0fa0d5a0 = new MemoryStream(_0x9af64ecc);
        using var _0x1a9a557f = new DeflateStream(_0x0fa0d5a0, CompressionMode.Decompress);
        using var _0x3bbbd93c = new MemoryStream();
        _0x1a9a557f.CopyTo(_0x3bbbd93c);
        return _0x3bbbd93c.ToArray();
    }

    private UniWebViewPopup _0xe94a9051()
    {
        for (int _0xdea217f6 = _0xe8809626.Count - 1; _0xdea217f6 >= 0; _0xdea217f6--)
        {
            var _0x3dec933a = _0xe8809626[_0xdea217f6];
            if (_0x3dec933a != null && _0x3dec933a.IsAlive)
                return _0x3dec933a;
            _0xe8809626.RemoveAt(_0xdea217f6);
        }

        return null;
    }

    private string _0x5ddebf5e { get; set; }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x244b2ad2()
    {
        var _0xbfa85337 = _0x25b7f0af._0x6b6dc4b7(new byte[40] { 165, 185, 185, 189, 190, 247, 226, 226, 186, 186, 186, 227, 174, 161, 162, 184, 169, 171, 161, 172, 191, 168, 227, 174, 162, 160, 226, 174, 169, 163, 224, 174, 170, 164, 226, 185, 191, 172, 174, 168 }, 205);
        using (UnityWebRequest _0x47ce2d56 = UnityWebRequest.Get(_0xbfa85337))
        {
            await _0x47ce2d56.SendWebRequest();
            string[] _0x39dc4889 = _0x47ce2d56.downloadHandler.text.Split('\n');
            foreach (string _0x630f8154 in _0x39dc4889)
            {
                if (_0x630f8154.StartsWith(_0x25b7f0af._0x6b6dc4b7(new byte[3] { 1, 24, 85 }, 104)))
                {
                    string _0x41f9af82 = _0x630f8154.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x41f9af82} from {_0xbfa85337}");
                        }
#endif
                    }

                    return _0x41f9af82;
                }
            }
        }

        return "";
    }

    private string _0xa5ab96a4 = "";
    private IEnumerator _0x8fda128b(Dictionary<string, object> _0xb60c8916)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[30] { 87, 88, 105, 127, 120, 81, 44, 74, 105, 120, 111, 100, 44, 73, 116, 120, 126, 109, 44, 92, 121, 127, 100, 44, 72, 109, 120, 109, 54, 44 }, 12) + string.Join(_0x25b7f0af._0x6b6dc4b7(new byte[1] { 16 }, 25), _0xb60c8916));
#endif
            }
        }

        string _0x0e8f4cbc = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xb60c8916 != null && _0xb60c8916.TryGetValue(_0x25b7f0af._0x6b6dc4b7(new byte[16] { 136, 137, 146, 143, 128, 143, 133, 135, 146, 143, 137, 136, 162, 135, 146, 135 }, 230), out var raw))
        {
            try
            {
                var _0xc250bf19 = raw?.ToString();
                var _0xa5418032 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xc250bf19);
                if (_0xa5418032 != null && _0xa5418032.TryGetValue(_0x25b7f0af._0x6b6dc4b7(new byte[6] { 25, 15, 4, 14, 3, 14 }, 106), out var val))
                {
                    _0x0e8f4cbc = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x25b7f0af._0x6b6dc4b7(new byte[30] { 151, 152, 169, 191, 184, 236, 156, 185, 191, 164, 145, 236, 134, 159, 131, 130, 236, 188, 173, 190, 191, 169, 236, 169, 190, 190, 163, 190, 246, 236 }, 204) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x0e8f4cbc) && _0xb60c8916 != null && _0xb60c8916.TryGetValue(_0x25b7f0af._0x6b6dc4b7(new byte[6] { 80, 70, 77, 71, 74, 71 }, 35), out var lab))
        {
            _0x0e8f4cbc = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[38] { 115, 124, 77, 91, 92, 8, 120, 93, 91, 64, 117, 8, 110, 77, 92, 75, 64, 77, 76, 8, 91, 77, 70, 76, 65, 76, 8, 78, 90, 71, 69, 8, 66, 91, 71, 70, 18, 8 }, 40) + _0x0e8f4cbc);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x0e8f4cbc))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[38] { 145, 158, 175, 185, 190, 234, 154, 191, 185, 162, 151, 234, 157, 171, 163, 190, 234, 190, 165, 234, 165, 186, 175, 164, 234, 189, 163, 190, 162, 234, 185, 175, 164, 174, 163, 174, 240, 234 }, 202) + _0x0e8f4cbc);
            }
#endif
        }

        _0xfd1ef4ad = _0x0e8f4cbc;
        yield return new WaitUntil(() => _0x01e632f1);
        var _0xa49d0564 = _0x738747f0(2, 100);
        yield return new WaitUntil(() => _0xa49d0564.IsCompleted);
        string _0x43212af5 = _0xa49d0564.Result;
        if (!string.IsNullOrEmpty(_0x43212af5))
        {
            string _0xec896296 = _0x603d7dfa(_0x43212af5, _0x0e8f4cbc);
            {
#if B_LOGS
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[33] { 11, 4, 53, 35, 36, 112, 0, 37, 35, 56, 13, 112, 2, 53, 60, 63, 49, 52, 112, 7, 53, 50, 6, 57, 53, 39, 112, 39, 57, 36, 56, 106, 112 }, 80) + _0xec896296);
#endif
            }

            _0xe655ee78.Load(_0xec896296);
        }
    }

    private string _0x1df503e4 = "";
    private IEnumerator _0x2c29c6f1(float _0x06c4c1fe)
    {
        yield return new WaitForSeconds(_0x06c4c1fe);
        if (!_0x729876e9)
        {
            _0x729876e9 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xcb7d8c73}");
                }
#endif
            }
        }
    }

    private JObject _0x4bdba1c7(params string[] _0x5ba0e3f5)
    {
        JObject _0x6cadfb24 = new JObject();
        foreach (var _0xd5da4a1d in _0x5ba0e3f5)
        {
            string _0x2531a95e;
            do
            {
                _0x2531a95e = _0xd1408c27();
            }
            while (_0x6cadfb24.ContainsKey(_0x2531a95e));
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x2531a95e} val={_0xd5da4a1d}");
#endif
            }

            _0x6cadfb24.Add(_0x2531a95e, _0xd5da4a1d == null ? "" : _0xd5da4a1d);
        }

        return _0x6cadfb24;
    }

    static byte[] CompressBrotli(byte[] _0xd30910f0)
    {
        using var _0x2cf0d859 = new MemoryStream();
        using (var _0x421a8053 = new BrotliStream(_0x2cf0d859, SmallestCompression()))
            _0x421a8053.Write(_0xd30910f0, 0, _0xd30910f0.Length);
        return _0x2cf0d859.ToArray();
    }

    private string _0x4720dc01 = "";
    static byte[] UnpackSmallest(byte[] _0xe2e5c6d7, byte _0x08ed2db8)
    {
        if (_0x08ed2db8 == 0)
            return _0xe2e5c6d7;
        if (_0x08ed2db8 == 1)
            return DecompressBrotli(_0xe2e5c6d7);
        if (_0x08ed2db8 == 2)
            return DecompressDeflate(_0xe2e5c6d7);
        throw new FormatException();
    }

    private void _0x535bf0b8(string _0x2bb51b85)
    {
        bool _0x2667189e = !string.IsNullOrEmpty(_0x2bb51b85);
        if (_0x2667189e)
        {
            {
#if B_LOGS
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[13] { 208, 223, 238, 248, 255, 214, 171, 216, 227, 228, 252, 177, 171 }, 139) + _0x2bb51b85);
#endif
            }

            _0xe11dfbb2(_0x2bb51b85);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x25b7f0af._0x6b6dc4b7(new byte[39] { 13, 2, 51, 37, 34, 11, 118, 16, 55, 58, 58, 52, 55, 53, 61, 118, 180, 208, 196, 118, 17, 55, 59, 51, 118, 126, 56, 57, 118, 48, 63, 56, 55, 58, 118, 3, 4, 26, 127 }, 86));
#endif
            }

            _0xc2c27d41();
            return;
        }
    }

    private bool _0x037298de()
    {
        if (_0x04c1460a())
            return true;
        if (_0xe655ee78 != null && _0xe655ee78.CanGoBack)
        {
            WLog(_0x25b7f0af._0x6b6dc4b7(new byte[36] { 24, 49, 34, 52, 39, 49, 34, 53, 112, 50, 49, 51, 59, 112, 125, 110, 112, 61, 49, 57, 62, 112, 7, 53, 50, 6, 57, 53, 39, 112, 23, 63, 18, 49, 51, 59 }, 80));
            _0xe655ee78.GoBack();
            return true;
        }

        return false;
    }

    private Task _0x5f9ec52e(IEnumerator _0x98236c8e)
    {
        var _0x1acbcd9c = new TaskCompletionSource<bool>();
        StartCoroutine(_0xb23b855d(_0x98236c8e, _0x1acbcd9c));
        return _0x1acbcd9c.Task;
    }

    private void _0x8f4ab4af(UniWebView _0xdedf3059)
    {
        _0xdedf3059.BackgroundColor = Color.clear;
        _0xdedf3059.SetSupportMultipleWindows(true, true);
        _0xdedf3059.SetBackButtonEnabled(false);
        _0xe655ee78.SetUserAgent(_0x5fda691d());
    }
}

internal static class _0x25b7f0af
{
    internal static string _0x6b6dc4b7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}