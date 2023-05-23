using System;
using Foundation;
using ObjCRuntime;
using Segment;
using SystemConfiguration;
using UIKit;

namespace Segment
{
	// @interface AnalyticsConfiguration : NSObject
	[BaseType (typeof(NSObject), Name = "SEGAnalyticsConfiguration")]
	interface AnalyticsConfiguration
	{
		// +(instancetype _Nonnull)configurationWithWriteKey:(NSString * _Nonnull)writeKey;
		[Static]
		[Export ("configurationWithWriteKey:")]
		AnalyticsConfiguration ConfigurationWithWriteKey (string writeKey);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull writeKey;
		[Export ("writeKey")]
		string WriteKey { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable apiHost;
		[NullAllowed, Export ("apiHost", ArgumentSemantic.Copy)]
		NSUrl ApiHost { get; }

		// @property (assign, nonatomic) BOOL shouldUseLocationServices;
		[Export ("shouldUseLocationServices")]
		bool ShouldUseLocationServices { get; set; }

		// @property (assign, nonatomic) BOOL enableAdvertisingTracking;
		[Export ("enableAdvertisingTracking")]
		bool EnableAdvertisingTracking { get; set; }

		// @property (assign, nonatomic) NSUInteger flushAt;
		[Export ("flushAt")]
		nuint FlushAt { get; set; }

		// @property (assign, nonatomic) NSTimeInterval flushInterval;
		[Export ("flushInterval")]
		double FlushInterval { get; set; }

		// @property (assign, nonatomic) NSUInteger maxQueueSize;
		[Export ("maxQueueSize")]
		nuint MaxQueueSize { get; set; }

		// @property (assign, nonatomic) BOOL trackApplicationLifecycleEvents;
		[Export ("trackApplicationLifecycleEvents")]
		bool TrackApplicationLifecycleEvents { get; set; }

		// @property (assign, nonatomic) BOOL shouldUseBluetooth;
		[Export ("shouldUseBluetooth")]
		bool ShouldUseBluetooth { get; set; }

		// @property (assign, nonatomic) BOOL recordScreenViews;
		[Export ("recordScreenViews")]
		bool RecordScreenViews { get; set; }

		// @property (assign, nonatomic) BOOL trackInAppPurchases;
		[Export ("trackInAppPurchases")]
		bool TrackInAppPurchases { get; set; }

		// @property (assign, nonatomic) BOOL trackPushNotifications;
		[Export ("trackPushNotifications")]
		bool TrackPushNotifications { get; set; }

		// @property (assign, nonatomic) BOOL trackDeepLinks;
		[Export ("trackDeepLinks")]
		bool TrackDeepLinks { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nullable launchOptions;
		[NullAllowed, Export ("launchOptions", ArgumentSemantic.Strong)]
		NSDictionary LaunchOptions { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nullable defaultSettings;
		[NullAllowed, Export ("defaultSettings", ArgumentSemantic.Strong)]
		NSDictionary DefaultSettings { get; set; }
	}

	// @interface Analytics : NSObject
	[BaseType (typeof(NSObject), Name = "SEGAnalytics")]
	interface Analytics
	{
		// @property (readonly, nonatomic, strong) DEPRECATED_MSG_ATTRIBUTE("One time use object") AnalyticsConfiguration * configuration __attribute__((deprecated("One time use object")));
		[Export ("configuration", ArgumentSemantic.Strong)]
		AnalyticsConfiguration Configuration { get; }

		// -(instancetype _Nonnull)initWithConfiguration:(AnalyticsConfiguration * _Nonnull)configuration;
		[Export ("initWithConfiguration:")]
		NativeHandle Constructor (AnalyticsConfiguration configuration);

		// +(void)setupWithConfiguration:(AnalyticsConfiguration * _Nonnull)configuration;
		[Static]
		[Export ("setupWithConfiguration:")]
		void Setup (AnalyticsConfiguration configuration);

		// +(void)debug:(BOOL)showDebugLogs;
		[Static]
		[Export ("debug:")]
		void Debug (bool showDebugLogs);

		// +(instancetype _Nonnull)sharedAnalytics;
		[Static]
		[Export ("sharedAnalytics")]
		Analytics Shared { get; }

		// -(void)identify:(NSString * _Nullable)userId traits:(NSDictionary<NSString *,id> * _Nullable)traits options:(NSDictionary<NSString *,id> * _Nullable)options;
		[Export ("identify:traits:options:")]
		void Identify ([NullAllowed] string userId, [NullAllowed] NSDictionary<NSString, NSObject> traits, [NullAllowed] NSDictionary<NSString, NSObject> options);

		// -(void)identify:(NSString * _Nullable)userId traits:(NSDictionary<NSString *,id> * _Nullable)traits;
		[Export ("identify:traits:")]
		void Identify ([NullAllowed] string userId, [NullAllowed] NSDictionary<NSString, NSObject> traits);

		// -(void)identify:(NSString * _Nullable)userId;
		[Export ("identify:")]
		void Identify ([NullAllowed] string userId);

		// -(void)track:(NSString * _Nonnull)event properties:(NSDictionary<NSString *,id> * _Nullable)properties options:(NSDictionary<NSString *,id> * _Nullable)options;
		[Export ("track:properties:options:")]
		void Track (string @event, [NullAllowed] NSDictionary<NSString, NSObject> properties, [NullAllowed] NSDictionary<NSString, NSObject> options);

		// -(void)track:(NSString * _Nonnull)event properties:(NSDictionary<NSString *,id> * _Nullable)properties;
		[Export ("track:properties:")]
		void Track (string @event, [NullAllowed] NSDictionary<NSString, NSObject> properties);

		// -(void)track:(NSString * _Nonnull)event;
		[Export ("track:")]
		void Track (string @event);

		// -(void)screen:(NSString * _Nonnull)screenTitle category:(NSString * _Nullable)category properties:(NSDictionary<NSString *,id> * _Nullable)properties options:(NSDictionary<NSString *,id> * _Nullable)options;
		[Export ("screen:category:properties:options:")]
		void Screen (string screenTitle, [NullAllowed] string category, [NullAllowed] NSDictionary<NSString, NSObject> properties, [NullAllowed] NSDictionary<NSString, NSObject> options);

		// -(void)screen:(NSString * _Nonnull)screenTitle properties:(NSDictionary<NSString *,id> * _Nullable)properties options:(NSDictionary<NSString *,id> * _Nullable)options;
		[Export ("screen:properties:options:")]
		void Screen (string screenTitle, [NullAllowed] NSDictionary<NSString, NSObject> properties, [NullAllowed] NSDictionary<NSString, NSObject> options);

		// -(void)screen:(NSString * _Nonnull)screenTitle category:(NSString * _Nullable)category properties:(NSDictionary<NSString *,id> * _Nullable)properties;
		[Export ("screen:category:properties:")]
		void Screen (string screenTitle, [NullAllowed] string category, [NullAllowed] NSDictionary<NSString, NSObject> properties);

		// -(void)screen:(NSString * _Nonnull)screenTitle properties:(NSDictionary<NSString *,id> * _Nullable)properties;
		[Export ("screen:properties:")]
		void Screen (string screenTitle, [NullAllowed] NSDictionary<NSString, NSObject> properties);

		// -(void)screen:(NSString * _Nonnull)screenTitle category:(NSString * _Nullable)category;
		[Export ("screen:category:")]
		void Screen (string screenTitle, [NullAllowed] string category);

		// -(void)screen:(NSString * _Nonnull)screenTitle;
		[Export ("screen:")]
		void Screen (string screenTitle);

		// -(void)group:(NSString * _Nonnull)groupId traits:(NSDictionary<NSString *,id> * _Nullable)traits options:(NSDictionary<NSString *,id> * _Nullable)options;
		[Export ("group:traits:options:")]
		void Group (string groupId, [NullAllowed] NSDictionary<NSString, NSObject> traits, [NullAllowed] NSDictionary<NSString, NSObject> options);

		// -(void)group:(NSString * _Nonnull)groupId traits:(NSDictionary<NSString *,id> * _Nullable)traits;
		[Export ("group:traits:")]
		void Group (string groupId, [NullAllowed] NSDictionary<NSString, NSObject> traits);

		// -(void)group:(NSString * _Nonnull)groupId;
		[Export ("group:")]
		void Group (string groupId);

		// -(void)alias:(NSString * _Nonnull)newId options:(NSDictionary<NSString *,id> * _Nullable)options;
		[Export ("alias:options:")]
		void Alias (string newId, [NullAllowed] NSDictionary<NSString, NSObject> options);

		// -(void)alias:(NSString * _Nonnull)newId;
		[Export ("alias:")]
		void Alias (string newId);

		// -(void)flush;
		[Export ("flush")]
		void Flush ();

		// -(void)reset;
		[Export ("reset")]
		void Reset ();

		// -(void)enable;
		[Export ("enable")]
		void Enable ();

		// -(void)disable;
		[Export ("disable")]
		void Disable ();

		// +(NSString * _Nonnull)version;
		[Static]
		[Export ("version")]
		string Version { get; }

		// -(NSString * _Nonnull)getAnonymousId;
		[Export ("getAnonymousId")]
		string AnonymousId { get; }

		// -(NSString * _Nonnull)getDeviceToken;
		[Export ("getDeviceToken")]
		string DeviceToken { get; }
	}
}
