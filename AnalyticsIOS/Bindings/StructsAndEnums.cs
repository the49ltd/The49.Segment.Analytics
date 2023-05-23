using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Segment
{
	[Native]
	public enum SEGEventType : long
	{
		Undefined,
		Identify,
		Track,
		Screen,
		Group,
		Alias,
		Reset,
		Flush,
		ReceivedRemoteNotification,
		FailedToRegisterForRemoteNotifications,
		RegisteredForRemoteNotifications,
		HandleActionWithForRemoteNotification,
		ApplicationLifecycle,
		ContinueUserActivity,
		OpenURL
	}

	static class CFunctions
	{
		// extern void SEGSetShowDebugLogs (BOOL showDebugLogs);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern void SEGSetShowDebugLogs (bool showDebugLogs);

		// extern void SEGLog (NSString * _Nonnull format, ...);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern void SEGLog (NSString format, IntPtr varArgs);
	}

	[Native]
	public enum SEGNetworkStatus : long
	{
		NotReachable = 0,
		ReachableViaWiFi = 2,
		ReachableViaWWAN = 1
	}
}
