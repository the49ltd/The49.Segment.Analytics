using System;
using Foundation;
using ObjCRuntime;
using Segment;
using SystemConfiguration;
using UIKit;

namespace Segment
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double SegmentVersionNumber;
		[Field ("SegmentVersionNumber", "__Internal")]
		double SegmentVersionNumber { get; }

		// extern const unsigned char[] SegmentVersionString;
		[Field ("SegmentVersionString", "__Internal")]
		byte[] SegmentVersionString { get; }
	}

	// @interface SEGPayload : NSObject
	[BaseType (typeof(NSObject))]
	interface SEGPayload
	{
		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull context;
		[Export ("context")]
		NSDictionary<NSString, NSObject> Context { get; }

		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull integrations;
		[Export ("integrations")]
		NSDictionary<NSString, NSObject> Integrations { get; }

		// @property (nonatomic, strong) NSString * _Nonnull timestamp;
		[Export ("timestamp", ArgumentSemantic.Strong)]
		string Timestamp { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull messageId;
		[Export ("messageId", ArgumentSemantic.Strong)]
		string MessageId { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull anonymousId;
		[Export ("anonymousId", ArgumentSemantic.Strong)]
		string AnonymousId { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull userId;
		[Export ("userId", ArgumentSemantic.Strong)]
		string UserId { get; set; }

		// -(instancetype _Nonnull)initWithContext:(NSDictionary<NSString *,id> * _Nonnull)context integrations:(NSDictionary<NSString *,id> * _Nonnull)integrations;
		[Export ("initWithContext:integrations:")]
		NativeHandle Constructor (NSDictionary<NSString, NSObject> context, NSDictionary<NSString, NSObject> integrations);
	}

	// @interface SEGApplicationLifecyclePayload : SEGPayload
	[BaseType (typeof(SEGPayload))]
	interface SEGApplicationLifecyclePayload
	{
		// @property (nonatomic, strong) NSString * _Nonnull notificationName;
		[Export ("notificationName", ArgumentSemantic.Strong)]
		string NotificationName { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nullable launchOptions;
		[NullAllowed, Export ("launchOptions", ArgumentSemantic.Strong)]
		NSDictionary LaunchOptions { get; set; }
	}

	// @interface SEGContinueUserActivityPayload : SEGPayload
	[BaseType (typeof(SEGPayload))]
	interface SEGContinueUserActivityPayload
	{
		// @property (nonatomic, strong) NSUserActivity * _Nonnull activity;
		[Export ("activity", ArgumentSemantic.Strong)]
		NSUserActivity Activity { get; set; }
	}

	// @interface SEGOpenURLPayload : SEGPayload
	[BaseType (typeof(SEGPayload))]
	interface SEGOpenURLPayload
	{
		// @property (nonatomic, strong) NSURL * _Nonnull url;
		[Export ("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nonnull options;
		[Export ("options", ArgumentSemantic.Strong)]
		NSDictionary Options { get; set; }
	}

	// @interface SEGRemoteNotificationPayload : SEGPayload
	[BaseType (typeof(SEGPayload))]
	interface SEGRemoteNotificationPayload
	{
		// @property (nonatomic, strong) NSString * _Nullable actionIdentifier;
		[NullAllowed, Export ("actionIdentifier", ArgumentSemantic.Strong)]
		string ActionIdentifier { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nullable userInfo;
		[NullAllowed, Export ("userInfo", ArgumentSemantic.Strong)]
		NSDictionary UserInfo { get; set; }

		// @property (nonatomic, strong) NSError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Strong)]
		NSError Error { get; set; }

		// @property (nonatomic, strong) NSData * _Nullable deviceToken;
		[NullAllowed, Export ("deviceToken", ArgumentSemantic.Strong)]
		NSData DeviceToken { get; set; }
	}

	// @interface SEGIdentifyPayload : SEGPayload
	[BaseType (typeof(SEGPayload))]
	interface SEGIdentifyPayload
	{
		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nullable traits;
		[NullAllowed, Export ("traits")]
		NSDictionary<NSString, NSObject> Traits { get; }

		// -(instancetype _Nonnull)initWithUserId:(NSString * _Nonnull)userId anonymousId:(NSString * _Nullable)anonymousId traits:(NSDictionary<NSString *,id> * _Nullable)traits context:(NSDictionary<NSString *,id> * _Nonnull)context integrations:(NSDictionary<NSString *,id> * _Nonnull)integrations;
		[Export ("initWithUserId:anonymousId:traits:context:integrations:")]
		NativeHandle Constructor (string userId, [NullAllowed] string anonymousId, [NullAllowed] NSDictionary<NSString, NSObject> traits, NSDictionary<NSString, NSObject> context, NSDictionary<NSString, NSObject> integrations);
	}

	// @interface SEGTrackPayload : SEGPayload
	[BaseType (typeof(SEGPayload))]
	interface SEGTrackPayload
	{
		// @property (readonly, nonatomic) NSString * _Nonnull event;
		[Export ("event")]
		string Event { get; }

		// @property (readonly, nonatomic) NSDictionary * _Nullable properties;
		[NullAllowed, Export ("properties")]
		NSDictionary Properties { get; }

		// -(instancetype _Nonnull)initWithEvent:(NSString * _Nonnull)event properties:(NSDictionary * _Nullable)properties context:(NSDictionary * _Nonnull)context integrations:(NSDictionary * _Nonnull)integrations;
		[Export ("initWithEvent:properties:context:integrations:")]
		NativeHandle Constructor (string @event, [NullAllowed] NSDictionary properties, NSDictionary context, NSDictionary integrations);
	}

	// @interface SEGScreenPayload : SEGPayload
	[BaseType (typeof(SEGPayload))]
	interface SEGScreenPayload
	{
		// @property (readonly, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) NSString * _Nullable category;
		[NullAllowed, Export ("category")]
		string Category { get; }

		// @property (readonly, nonatomic) NSDictionary * _Nullable properties;
		[NullAllowed, Export ("properties")]
		NSDictionary Properties { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name category:(NSString * _Nonnull)category properties:(NSDictionary * _Nullable)properties context:(NSDictionary * _Nonnull)context integrations:(NSDictionary * _Nonnull)integrations;
		[Export ("initWithName:category:properties:context:integrations:")]
		NativeHandle Constructor (string name, string category, [NullAllowed] NSDictionary properties, NSDictionary context, NSDictionary integrations);
	}

	// @interface SEGAliasPayload : SEGPayload
	[BaseType (typeof(SEGPayload))]
	interface SEGAliasPayload
	{
		// @property (readonly, nonatomic) NSString * _Nonnull theNewId;
		[Export ("theNewId")]
		string TheNewId { get; }

		// -(instancetype _Nonnull)initWithNewId:(NSString * _Nonnull)newId context:(NSDictionary<NSString *,id> * _Nonnull)context integrations:(NSDictionary<NSString *,id> * _Nonnull)integrations;
		[Export ("initWithNewId:context:integrations:")]
		NativeHandle Constructor (string newId, NSDictionary<NSString, NSObject> context, NSDictionary<NSString, NSObject> integrations);
	}

	// @interface SEGGroupPayload : SEGPayload
	[BaseType (typeof(SEGPayload))]
	interface SEGGroupPayload
	{
		// @property (readonly, nonatomic) NSString * _Nonnull groupId;
		[Export ("groupId")]
		string GroupId { get; }

		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nullable traits;
		[NullAllowed, Export ("traits")]
		NSDictionary<NSString, NSObject> Traits { get; }

		// -(instancetype _Nonnull)initWithGroupId:(NSString * _Nonnull)groupId traits:(NSDictionary<NSString *,id> * _Nullable)traits context:(NSDictionary<NSString *,id> * _Nonnull)context integrations:(NSDictionary<NSString *,id> * _Nonnull)integrations;
		[Export ("initWithGroupId:traits:context:integrations:")]
		NativeHandle Constructor (string groupId, [NullAllowed] NSDictionary<NSString, NSObject> traits, NSDictionary<NSString, NSObject> context, NSDictionary<NSString, NSObject> integrations);
	}

	// @interface SEGContext : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface SEGContext : INSCopying
	{
		// @property (readonly, nonatomic) SEGAnalytics * _Nonnull _analytics;
		[Export ("_analytics")]
		SEGAnalytics _analytics { get; }

		// @property (readonly, nonatomic) SEGEventType eventType;
		[Export ("eventType")]
		SEGEventType EventType { get; }

		// @property (readonly, nonatomic) NSError * _Nullable error;
		[NullAllowed, Export ("error")]
		NSError Error { get; }

		// @property (readonly, nonatomic) SEGPayload * _Nullable payload;
		[NullAllowed, Export ("payload")]
		SEGPayload Payload { get; }

		// @property (readonly, nonatomic) BOOL debug;
		[Export ("debug")]
		bool Debug { get; }

		// -(instancetype _Nonnull)initWithAnalytics:(SEGAnalytics * _Nonnull)analytics;
		[Export ("initWithAnalytics:")]
		NativeHandle Constructor (SEGAnalytics analytics);

		// -(SEGContext * _Nonnull)modify:(void (^ _Nonnull)(id<SEGMutableContext> _Nonnull))modify;
		[Export ("modify:")]
		SEGContext Modify (Action<SEGMutableContext> modify);
	}

	// @protocol SEGMutableContext <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SEGMutableContext
	{
		// @required @property (nonatomic) SEGEventType eventType;
		[Abstract]
		[Export ("eventType", ArgumentSemantic.Assign)]
		SEGEventType EventType { get; set; }

		// @required @property (nonatomic) SEGPayload * _Nullable payload;
		[Abstract]
		[NullAllowed, Export ("payload", ArgumentSemantic.Assign)]
		SEGPayload Payload { get; set; }

		// @required @property (nonatomic) NSError * _Nullable error;
		[Abstract]
		[NullAllowed, Export ("error", ArgumentSemantic.Assign)]
		NSError Error { get; set; }

		// @required @property (nonatomic) BOOL debug;
		[Abstract]
		[Export ("debug")]
		bool Debug { get; set; }
	}

	// @protocol SEGIntegration <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SEGIntegration
	{
		// @optional -(void)identify:(SEGIdentifyPayload * _Nonnull)payload;
		[Export ("identify:")]
		void Identify (SEGIdentifyPayload payload);

		// @optional -(void)track:(SEGTrackPayload * _Nonnull)payload;
		[Export ("track:")]
		void Track (SEGTrackPayload payload);

		// @optional -(void)screen:(SEGScreenPayload * _Nonnull)payload;
		[Export ("screen:")]
		void Screen (SEGScreenPayload payload);

		// @optional -(void)group:(SEGGroupPayload * _Nonnull)payload;
		[Export ("group:")]
		void Group (SEGGroupPayload payload);

		// @optional -(void)alias:(SEGAliasPayload * _Nonnull)payload;
		[Export ("alias:")]
		void Alias (SEGAliasPayload payload);

		// @optional -(void)reset;
		[Export ("reset")]
		void Reset ();

		// @optional -(void)flush;
		[Export ("flush")]
		void Flush ();

		// @optional -(void)receivedRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Export ("receivedRemoteNotification:")]
		void ReceivedRemoteNotification (NSDictionary userInfo);

		// @optional -(void)failedToRegisterForRemoteNotificationsWithError:(NSError * _Nonnull)error;
		[Export ("failedToRegisterForRemoteNotificationsWithError:")]
		void FailedToRegisterForRemoteNotificationsWithError (NSError error);

		// @optional -(void)registeredForRemoteNotificationsWithDeviceToken:(NSData * _Nonnull)deviceToken;
		[Export ("registeredForRemoteNotificationsWithDeviceToken:")]
		void RegisteredForRemoteNotificationsWithDeviceToken (NSData deviceToken);

		// @optional -(void)handleActionWithIdentifier:(NSString * _Nonnull)identifier forRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Export ("handleActionWithIdentifier:forRemoteNotification:")]
		void HandleActionWithIdentifier (string identifier, NSDictionary userInfo);

		// @optional -(void)applicationDidFinishLaunching:(NSNotification * _Nonnull)notification;
		[Export ("applicationDidFinishLaunching:")]
		void ApplicationDidFinishLaunching (NSNotification notification);

		// @optional -(void)applicationDidEnterBackground;
		[Export ("applicationDidEnterBackground")]
		void ApplicationDidEnterBackground ();

		// @optional -(void)applicationWillEnterForeground;
		[Export ("applicationWillEnterForeground")]
		void ApplicationWillEnterForeground ();

		// @optional -(void)applicationWillTerminate;
		[Export ("applicationWillTerminate")]
		void ApplicationWillTerminate ();

		// @optional -(void)applicationWillResignActive;
		[Export ("applicationWillResignActive")]
		void ApplicationWillResignActive ();

		// @optional -(void)applicationDidBecomeActive;
		[Export ("applicationDidBecomeActive")]
		void ApplicationDidBecomeActive ();

		// @optional -(void)continueUserActivity:(NSUserActivity * _Nonnull)activity;
		[Export ("continueUserActivity:")]
		void ContinueUserActivity (NSUserActivity activity);

		// @optional -(void)openURL:(NSURL * _Nonnull)url options:(NSDictionary * _Nonnull)options;
		[Export ("openURL:options:")]
		void OpenURL (NSUrl url, NSDictionary options);
	}

	// @protocol SEGIntegrationFactory
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface SEGIntegrationFactory
	{
		// @required -(id<SEGIntegration> _Nonnull)createWithSettings:(NSDictionary * _Nonnull)settings forAnalytics:(SEGAnalytics * _Nonnull)analytics;
		[Abstract]
		[Export ("createWithSettings:forAnalytics:")]
		SEGIntegration ForAnalytics (NSDictionary settings, SEGAnalytics analytics);

		// @required -(NSString * _Nonnull)key;
		[Abstract]
		[Export ("key")]
		[Verify (MethodToProperty)]
		string Key { get; }
	}

	// @protocol SEGCrypto <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SEGCrypto
	{
		// @required -(NSData * _Nullable)encrypt:(NSData * _Nonnull)data;
		[Abstract]
		[Export ("encrypt:")]
		[return: NullAllowed]
		NSData Encrypt (NSData data);

		// @required -(NSData * _Nullable)decrypt:(NSData * _Nonnull)data;
		[Abstract]
		[Export ("decrypt:")]
		[return: NullAllowed]
		NSData Decrypt (NSData data);
	}

	// @protocol SEGApplicationProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SEGApplicationProtocol
	{
		[Wrap ("WeakDelegate"), Abstract]
		[NullAllowed]
		UIApplicationDelegate Delegate { get; set; }

		// @required @property (assign, nonatomic) id<UIApplicationDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @required -(NSUInteger)seg_beginBackgroundTaskWithName:(NSString * _Nullable)taskName expirationHandler:(void (^ _Nullable)(void))handler;
		[Abstract]
		[Export ("seg_beginBackgroundTaskWithName:expirationHandler:")]
		nuint Seg_beginBackgroundTaskWithName ([NullAllowed] string taskName, [NullAllowed] Action handler);

		// @required -(void)seg_endBackgroundTask:(NSUInteger)identifier;
		[Abstract]
		[Export ("seg_endBackgroundTask:")]
		void Seg_endBackgroundTask (nuint identifier);
	}

	// @interface SEGApplicationProtocol (UIApplication) <SEGApplicationProtocol>
	[Category]
	[BaseType (typeof(UIApplication))]
	interface UIApplication_SEGApplicationProtocol : ISEGApplicationProtocol
	{
	}

	// typedef NSMutableURLRequest * _Nonnull (^SEGRequestFactory)(NSURL * _Nonnull);
	delegate NSMutableUrlRequest SEGRequestFactory (NSUrl arg0);

	// typedef NSString * _Nonnull (^SEGAdSupportBlock)();
	delegate string SEGAdSupportBlock ();

	// @interface SEGAnalyticsConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface SEGAnalyticsConfiguration
	{
		// +(instancetype _Nonnull)configurationWithWriteKey:(NSString * _Nonnull)writeKey;
		[Static]
		[Export ("configurationWithWriteKey:")]
		SEGAnalyticsConfiguration ConfigurationWithWriteKey (string writeKey);

		// +(instancetype _Nonnull)configurationWithWriteKey:(NSString * _Nonnull)writeKey defaultAPIHost:(NSURL * _Nullable)defaultAPIHost;
		[Static]
		[Export ("configurationWithWriteKey:defaultAPIHost:")]
		SEGAnalyticsConfiguration ConfigurationWithWriteKey (string writeKey, [NullAllowed] NSUrl defaultAPIHost);

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

		// @property (nonatomic, strong) SEGRequestFactory _Nullable requestFactory;
		[NullAllowed, Export ("requestFactory", ArgumentSemantic.Strong)]
		SEGRequestFactory RequestFactory { get; set; }

		// @property (nonatomic, strong) id<SEGCrypto> _Nullable crypto;
		[NullAllowed, Export ("crypto", ArgumentSemantic.Strong)]
		SEGCrypto Crypto { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nullable defaultSettings;
		[NullAllowed, Export ("defaultSettings", ArgumentSemantic.Strong)]
		NSDictionary DefaultSettings { get; set; }

		// @property (nonatomic, strong) DEPRECATED_MSG_ATTRIBUTE("Use .sourceMiddleware instead.") NSArray<id<SEGMiddleware>> * middlewares __attribute__((deprecated("Use .sourceMiddleware instead.")));
		[Export ("middlewares", ArgumentSemantic.Strong)]
		SEGMiddleware[] Middlewares { get; set; }

		// @property (nonatomic, strong) NSArray<id<SEGMiddleware>> * _Nullable sourceMiddleware;
		[NullAllowed, Export ("sourceMiddleware", ArgumentSemantic.Strong)]
		SEGMiddleware[] SourceMiddleware { get; set; }

		// @property (nonatomic, strong) NSArray<SEGDestinationMiddleware *> * _Nullable destinationMiddleware;
		[NullAllowed, Export ("destinationMiddleware", ArgumentSemantic.Strong)]
		SEGDestinationMiddleware[] DestinationMiddleware { get; set; }

		// @property (nonatomic, strong) id<SEGEdgeFunctionMiddleware> _Nullable edgeFunctionMiddleware;
		[NullAllowed, Export ("edgeFunctionMiddleware", ArgumentSemantic.Strong)]
		SEGEdgeFunctionMiddleware EdgeFunctionMiddleware { get; set; }

		// -(void)use:(id<SEGIntegrationFactory> _Nonnull)factory;
		[Export ("use:")]
		void Use (SEGIntegrationFactory factory);

		// @property (nonatomic, strong) id<SEGApplicationProtocol> _Nullable application;
		[NullAllowed, Export ("application", ArgumentSemantic.Strong)]
		SEGApplicationProtocol Application { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nonnull payloadFilters;
		[Export ("payloadFilters", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> PayloadFilters { get; set; }

		[Wrap ("WeakHttpSessionDelegate")]
		[NullAllowed]
		NSUrlSessionDelegate HttpSessionDelegate { get; set; }

		// @property (nonatomic, strong) id<NSURLSessionDelegate> _Nullable httpSessionDelegate;
		[NullAllowed, Export ("httpSessionDelegate", ArgumentSemantic.Strong)]
		NSObject WeakHttpSessionDelegate { get; set; }

		// @property (nonatomic, strong) SEGAdSupportBlock _Nullable adSupportBlock;
		[NullAllowed, Export ("adSupportBlock", ArgumentSemantic.Strong)]
		SEGAdSupportBlock AdSupportBlock { get; set; }

		// @property (readonly, nonatomic) SEGAnalyticsExperimental * _Nonnull experimental;
		[Export ("experimental")]
		SEGAnalyticsExperimental Experimental { get; }
	}

	// typedef NSDictionary * _Nonnull (^SEGRawModificationBlock)(NSDictionary * _Nonnull);
	delegate NSDictionary SEGRawModificationBlock (NSDictionary arg0);

	// @interface SEGAnalyticsExperimental : NSObject
	[BaseType (typeof(NSObject))]
	interface SEGAnalyticsExperimental
	{
		// @property (assign, nonatomic) BOOL nanosecondTimestamps;
		[Export ("nanosecondTimestamps")]
		bool NanosecondTimestamps { get; set; }

		// @property (nonatomic, strong) SEGRawModificationBlock _Nullable rawSegmentModificationBlock;
		[NullAllowed, Export ("rawSegmentModificationBlock", ArgumentSemantic.Strong)]
		SEGRawModificationBlock RawSegmentModificationBlock { get; set; }
	}

	// typedef void (^SEGMiddlewareNext)(SEGContext * _Nullable);
	delegate void SEGMiddlewareNext ([NullAllowed] SEGContext arg0);

	// @protocol SEGMiddleware
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface SEGMiddleware
	{
		// @required -(void)context:(SEGContext * _Nonnull)context next:(SEGMiddlewareNext _Nonnull)next;
		[Abstract]
		[Export ("context:next:")]
		void Next (SEGContext context, SEGMiddlewareNext next);
	}

	// typedef void (^SEGMiddlewareBlock)(SEGContext * _Nonnull, SEGMiddlewareNext _Nonnull);
	delegate void SEGMiddlewareBlock (SEGContext arg0, SEGMiddlewareNext arg1);

	// @interface SEGBlockMiddleware : NSObject <SEGMiddleware>
	[BaseType (typeof(NSObject))]
	interface SEGBlockMiddleware : ISEGMiddleware
	{
		// @property (readonly, nonatomic) SEGMiddlewareBlock _Nonnull block;
		[Export ("block")]
		SEGMiddlewareBlock Block { get; }

		// -(instancetype _Nonnull)initWithBlock:(SEGMiddlewareBlock _Nonnull)block;
		[Export ("initWithBlock:")]
		NativeHandle Constructor (SEGMiddlewareBlock block);
	}

	// typedef void (^RunMiddlewaresCallback)(BOOL, NSArray<id<SEGMiddleware>> * _Nonnull);
	delegate void RunMiddlewaresCallback (bool arg0, SEGMiddleware[] arg1);

	// @interface SEGMiddlewareRunner : NSObject
	[BaseType (typeof(NSObject))]
	interface SEGMiddlewareRunner
	{
		// @property (readonly, nonatomic) NSArray<id<SEGMiddleware>> * _Nonnull middlewares;
		[Export ("middlewares")]
		SEGMiddleware[] Middlewares { get; }

		// -(SEGContext * _Nonnull)run:(SEGContext * _Nonnull)context callback:(RunMiddlewaresCallback _Nullable)callback;
		[Export ("run:callback:")]
		SEGContext Run (SEGContext context, [NullAllowed] RunMiddlewaresCallback callback);

		// -(instancetype _Nonnull)initWithMiddleware:(NSArray<id<SEGMiddleware>> * _Nonnull)middlewares;
		[Export ("initWithMiddleware:")]
		NativeHandle Constructor (SEGMiddleware[] middlewares);
	}

	// @interface SEGDestinationMiddleware : NSObject
	[BaseType (typeof(NSObject))]
	interface SEGDestinationMiddleware
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull integrationKey;
		[Export ("integrationKey", ArgumentSemantic.Strong)]
		string IntegrationKey { get; }

		// @property (readonly, nonatomic, strong) NSArray<id<SEGMiddleware>> * _Nullable middleware;
		[NullAllowed, Export ("middleware", ArgumentSemantic.Strong)]
		SEGMiddleware[] Middleware { get; }

		// -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)integrationKey middleware:(NSArray<id<SEGMiddleware>> * _Nonnull)middleware;
		[Export ("initWithKey:middleware:")]
		NativeHandle Constructor (string integrationKey, SEGMiddleware[] middleware);
	}

	// @protocol SEGEdgeFunctionMiddleware
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface SEGEdgeFunctionMiddleware
	{
		// @required @property (readonly, nonatomic) NSArray<id<SEGMiddleware>> * _Nullable sourceMiddleware;
		[Abstract]
		[NullAllowed, Export ("sourceMiddleware")]
		SEGMiddleware[] SourceMiddleware { get; }

		// @required @property (readonly, nonatomic) NSArray<SEGDestinationMiddleware *> * _Nullable destinationMiddleware;
		[Abstract]
		[NullAllowed, Export ("destinationMiddleware")]
		SEGDestinationMiddleware[] DestinationMiddleware { get; }

		// @required -(void)setEdgeFunctionData:(NSDictionary * _Nullable)data;
		[Abstract]
		[Export ("setEdgeFunctionData:")]
		void SetEdgeFunctionData ([NullAllowed] NSDictionary data);

		// @required -(void)addToDataBridge:(NSString * _Nonnull)key value:(id _Nonnull)value __attribute__((swift_name("addToDataBridge(key:value:)")));
		[Abstract]
		[Export ("addToDataBridge:value:")]
		void AddToDataBridge (string key, NSObject value);

		// @required -(void)removeFromDataBridge:(NSString * _Nonnull)key __attribute__((swift_name("removeFromDataBridge(key:)")));
		[Abstract]
		[Export ("removeFromDataBridge:")]
		void RemoveFromDataBridge (string key);

		// @required -(NSDictionary<NSString *,id> * _Nullable)dataBridgeSnapshot;
		[Abstract]
		[NullAllowed, Export ("dataBridgeSnapshot")]
		[Verify (MethodToProperty)]
		NSDictionary<NSString, NSObject> DataBridgeSnapshot { get; }
	}

	// @interface SEGAnalytics : NSObject
	[BaseType (typeof(NSObject))]
	interface SEGAnalytics
	{
		// @property (readonly, nonatomic, strong) DEPRECATED_MSG_ATTRIBUTE("One time use object") SEGAnalyticsConfiguration * configuration __attribute__((deprecated("One time use object")));
		[Export ("configuration", ArgumentSemantic.Strong)]
		SEGAnalyticsConfiguration Configuration { get; }

		// -(instancetype _Nonnull)initWithConfiguration:(SEGAnalyticsConfiguration * _Nonnull)configuration;
		[Export ("initWithConfiguration:")]
		NativeHandle Constructor (SEGAnalyticsConfiguration configuration);

		// +(void)setupWithConfiguration:(SEGAnalyticsConfiguration * _Nonnull)configuration;
		[Static]
		[Export ("setupWithConfiguration:")]
		void SetupWithConfiguration (SEGAnalyticsConfiguration configuration);

		// +(void)debug:(BOOL)showDebugLogs;
		[Static]
		[Export ("debug:")]
		void Debug (bool showDebugLogs);

		// +(instancetype _Nonnull)sharedAnalytics;
		[Static]
		[Export ("sharedAnalytics")]
		SEGAnalytics SharedAnalytics ();

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

		// -(void)receivedRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Export ("receivedRemoteNotification:")]
		void ReceivedRemoteNotification (NSDictionary userInfo);

		// -(void)failedToRegisterForRemoteNotificationsWithError:(NSError * _Nonnull)error;
		[Export ("failedToRegisterForRemoteNotificationsWithError:")]
		void FailedToRegisterForRemoteNotificationsWithError (NSError error);

		// -(void)registeredForRemoteNotificationsWithDeviceToken:(NSData * _Nonnull)deviceToken;
		[Export ("registeredForRemoteNotificationsWithDeviceToken:")]
		void RegisteredForRemoteNotificationsWithDeviceToken (NSData deviceToken);

		// -(void)handleActionWithIdentifier:(NSString * _Nonnull)identifier forRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Export ("handleActionWithIdentifier:forRemoteNotification:")]
		void HandleActionWithIdentifier (string identifier, NSDictionary userInfo);

		// -(void)continueUserActivity:(NSUserActivity * _Nonnull)activity;
		[Export ("continueUserActivity:")]
		void ContinueUserActivity (NSUserActivity activity);

		// -(void)openURL:(NSURL * _Nonnull)url options:(NSDictionary * _Nonnull)options;
		[Export ("openURL:options:")]
		void OpenURL (NSUrl url, NSDictionary options);

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
		[Verify (MethodToProperty)]
		string Version { get; }

		// -(NSDictionary * _Nonnull)bundledIntegrations;
		[Export ("bundledIntegrations")]
		[Verify (MethodToProperty)]
		NSDictionary BundledIntegrations { get; }

		// -(NSString * _Nonnull)getAnonymousId;
		[Export ("getAnonymousId")]
		[Verify (MethodToProperty)]
		string AnonymousId { get; }

		// -(NSString * _Nonnull)getDeviceToken;
		[Export ("getDeviceToken")]
		[Verify (MethodToProperty)]
		string DeviceToken { get; }

		// -(id<SEGEdgeFunctionMiddleware> _Nullable)edgeFunction;
		[NullAllowed, Export ("edgeFunction")]
		[Verify (MethodToProperty)]
		SEGEdgeFunctionMiddleware EdgeFunction { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull kSegmentAPIBaseHost;
		[Field ("kSegmentAPIBaseHost", "__Internal")]
		NSString kSegmentAPIBaseHost { get; }
	}

	// @interface SEGHTTPClient : NSObject
	[BaseType (typeof(NSObject))]
	interface SEGHTTPClient
	{
		// @property (nonatomic, strong) SEGRequestFactory _Nonnull requestFactory;
		[Export ("requestFactory", ArgumentSemantic.Strong)]
		SEGRequestFactory RequestFactory { get; set; }

		// @property (readonly, nonatomic) NSMutableDictionary<NSString *,NSURLSession *> * _Nonnull sessionsByWriteKey;
		[Export ("sessionsByWriteKey")]
		NSMutableDictionary<NSString, NSURLSession> SessionsByWriteKey { get; }

		// @property (readonly, nonatomic) NSURLSession * _Nonnull genericSession;
		[Export ("genericSession")]
		NSUrlSession GenericSession { get; }

		[Wrap ("WeakHttpSessionDelegate")]
		[NullAllowed]
		NSUrlSessionDelegate HttpSessionDelegate { get; set; }

		// @property (nonatomic, weak) id<NSURLSessionDelegate> _Nullable httpSessionDelegate;
		[NullAllowed, Export ("httpSessionDelegate", ArgumentSemantic.Weak)]
		NSObject WeakHttpSessionDelegate { get; set; }

		// +(SEGRequestFactory _Nonnull)defaultRequestFactory;
		[Static]
		[Export ("defaultRequestFactory")]
		[Verify (MethodToProperty)]
		SEGRequestFactory DefaultRequestFactory { get; }

		// +(NSString * _Nonnull)authorizationHeader:(NSString * _Nonnull)writeKey;
		[Static]
		[Export ("authorizationHeader:")]
		string AuthorizationHeader (string writeKey);

		// -(instancetype _Nonnull)initWithRequestFactory:(SEGRequestFactory _Nullable)requestFactory;
		[Export ("initWithRequestFactory:")]
		NativeHandle Constructor ([NullAllowed] SEGRequestFactory requestFactory);

		// -(NSURLSessionUploadTask * _Nullable)upload:(NSDictionary<NSString *,id> * _Nonnull)batch forWriteKey:(NSString * _Nonnull)writeKey completionHandler:(void (^ _Nonnull)(BOOL))completionHandler;
		[Export ("upload:forWriteKey:completionHandler:")]
		[return: NullAllowed]
		NSUrlSessionUploadTask Upload (NSDictionary<NSString, NSObject> batch, string writeKey, Action<bool> completionHandler);

		// -(NSURLSessionDataTask * _Nonnull)settingsForWriteKey:(NSString * _Nonnull)writeKey completionHandler:(void (^ _Nonnull)(BOOL, NSDictionary<NSString *,id> * _Nullable))completionHandler;
		[Export ("settingsForWriteKey:completionHandler:")]
		NSUrlSessionDataTask SettingsForWriteKey (string writeKey, Action<bool, NSDictionary<NSString, NSObject>> completionHandler);
	}

	// @protocol SEGStorage <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SEGStorage
	{
		// @required @property (nonatomic, strong) id<SEGCrypto> _Nullable crypto;
		[Abstract]
		[NullAllowed, Export ("crypto", ArgumentSemantic.Strong)]
		SEGCrypto Crypto { get; set; }

		// @required -(void)removeKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("removeKey:")]
		void RemoveKey (string key);

		// @required -(void)resetAll;
		[Abstract]
		[Export ("resetAll")]
		void ResetAll ();

		// @required -(void)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("setData:forKey:")]
		void SetData ([NullAllowed] NSData data, string key);

		// @required -(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("dataForKey:")]
		[return: NullAllowed]
		NSData DataForKey (string key);

		// @required -(void)setDictionary:(NSDictionary * _Nullable)dictionary forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("setDictionary:forKey:")]
		void SetDictionary ([NullAllowed] NSDictionary dictionary, string key);

		// @required -(NSDictionary * _Nullable)dictionaryForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("dictionaryForKey:")]
		[return: NullAllowed]
		NSDictionary DictionaryForKey (string key);

		// @required -(void)setArray:(NSArray * _Nullable)array forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("setArray:forKey:")]
		[Verify (StronglyTypedNSArray)]
		void SetArray ([NullAllowed] NSObject[] array, string key);

		// @required -(NSArray * _Nullable)arrayForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("arrayForKey:")]
		[Verify (StronglyTypedNSArray)]
		[return: NullAllowed]
		NSObject[] ArrayForKey (string key);

		// @required -(void)setString:(NSString * _Nullable)string forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("setString:forKey:")]
		void SetString ([NullAllowed] string @string, string key);

		// @required -(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("stringForKey:")]
		[return: NullAllowed]
		string StringForKey (string key);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull kSEGSegmentDestinationName;
		[Field ("kSEGSegmentDestinationName", "__Internal")]
		NSString kSEGSegmentDestinationName { get; }

		// extern NSString *const _Nonnull SEGSegmentDidSendRequestNotification;
		[Field ("SEGSegmentDidSendRequestNotification", "__Internal")]
		NSString SEGSegmentDidSendRequestNotification { get; }

		// extern NSString *const _Nonnull SEGSegmentRequestDidSucceedNotification;
		[Field ("SEGSegmentRequestDidSucceedNotification", "__Internal")]
		NSString SEGSegmentRequestDidSucceedNotification { get; }

		// extern NSString *const _Nonnull SEGSegmentRequestDidFailNotification;
		[Field ("SEGSegmentRequestDidFailNotification", "__Internal")]
		NSString SEGSegmentRequestDidFailNotification { get; }

		// extern NSString *const _Nonnull kSEGUserIdFilename;
		[Field ("kSEGUserIdFilename", "__Internal")]
		NSString kSEGUserIdFilename { get; }

		// extern NSString *const _Nonnull kSEGQueueFilename;
		[Field ("kSEGQueueFilename", "__Internal")]
		NSString kSEGQueueFilename { get; }

		// extern NSString *const _Nonnull kSEGTraitsFilename;
		[Field ("kSEGTraitsFilename", "__Internal")]
		NSString kSEGTraitsFilename { get; }
	}

	// @interface SEGSegmentIntegration : NSObject <SEGIntegration>
	[BaseType (typeof(NSObject))]
	interface SEGSegmentIntegration : ISEGIntegration
	{
		// -(id _Nonnull)initWithAnalytics:(SEGAnalytics * _Nonnull)analytics httpClient:(SEGHTTPClient * _Nonnull)httpClient fileStorage:(id<SEGStorage> _Nonnull)fileStorage userDefaultsStorage:(id<SEGStorage> _Nonnull)userDefaultsStorage;
		[Export ("initWithAnalytics:httpClient:fileStorage:userDefaultsStorage:")]
		NativeHandle Constructor (SEGAnalytics analytics, SEGHTTPClient httpClient, SEGStorage fileStorage, SEGStorage userDefaultsStorage);
	}

	// @interface SEGSegmentIntegrationFactory : NSObject <SEGIntegrationFactory>
	[BaseType (typeof(NSObject))]
	interface SEGSegmentIntegrationFactory : ISEGIntegrationFactory
	{
		// @property (nonatomic, strong) SEGHTTPClient * _Nonnull client;
		[Export ("client", ArgumentSemantic.Strong)]
		SEGHTTPClient Client { get; set; }

		// @property (nonatomic, strong) id<SEGStorage> _Nonnull userDefaultsStorage;
		[Export ("userDefaultsStorage", ArgumentSemantic.Strong)]
		SEGStorage UserDefaultsStorage { get; set; }

		// @property (nonatomic, strong) id<SEGStorage> _Nonnull fileStorage;
		[Export ("fileStorage", ArgumentSemantic.Strong)]
		SEGStorage FileStorage { get; set; }

		// -(instancetype _Nonnull)initWithHTTPClient:(SEGHTTPClient * _Nonnull)client fileStorage:(id<SEGStorage> _Nonnull)fileStorage userDefaultsStorage:(id<SEGStorage> _Nonnull)userDefaultsStorage;
		[Export ("initWithHTTPClient:fileStorage:userDefaultsStorage:")]
		NativeHandle Constructor (SEGHTTPClient client, SEGStorage fileStorage, SEGStorage userDefaultsStorage);
	}

	// @protocol SEGScreenReporting
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface SEGScreenReporting
	{
		// @optional -(void)seg_trackScreen:(UIViewController * _Nonnull)screen name:(NSString * _Nonnull)name;
		[Export ("seg_trackScreen:name:")]
		void Name (UIViewController screen, string name);

		// @optional @property (readonly) UIViewController * _Nullable seg_mainViewController;
		[NullAllowed, Export ("seg_mainViewController")]
		UIViewController Seg_mainViewController { get; }
	}

	// @protocol SEGSerializable
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface SEGSerializable
	{
		// @required -(id _Nonnull)serializeToAppropriateType;
		[Abstract]
		[Export ("serializeToAppropriateType")]
		[Verify (MethodToProperty)]
		NSObject SerializeToAppropriateType { get; }
	}

	// @interface SEGWebhookIntegrationFactory : NSObject <SEGIntegrationFactory>
	[BaseType (typeof(NSObject))]
	interface SEGWebhookIntegrationFactory : ISEGIntegrationFactory
	{
		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull webhookUrl;
		[Export ("webhookUrl")]
		string WebhookUrl { get; set; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name webhookUrl:(NSString * _Nonnull)webhookUrl;
		[Export ("initWithName:webhookUrl:")]
		NativeHandle Constructor (string name, string webhookUrl);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull kSEGReachabilityChangedNotification;
		[Field ("kSEGReachabilityChangedNotification", "__Internal")]
		NSString kSEGReachabilityChangedNotification { get; }
	}

	// typedef void (^SEGNetworkReachable)(SEGReachability * _Nonnull);
	delegate void SEGNetworkReachable (SEGReachability arg0);

	// typedef void (^SEGNetworkUnreachable)(SEGReachability * _Nonnull);
	delegate void SEGNetworkUnreachable (SEGReachability arg0);

	// @interface SEGReachability : NSObject
	[BaseType (typeof(NSObject))]
	interface SEGReachability
	{
		// @property (copy, nonatomic) SEGNetworkReachable _Nullable reachableBlock;
		[NullAllowed, Export ("reachableBlock", ArgumentSemantic.Copy)]
		SEGNetworkReachable ReachableBlock { get; set; }

		// @property (copy, nonatomic) SEGNetworkUnreachable _Nullable unreachableBlock;
		[NullAllowed, Export ("unreachableBlock", ArgumentSemantic.Copy)]
		SEGNetworkUnreachable UnreachableBlock { get; set; }

		// @property (assign, nonatomic) BOOL reachableOnWWAN;
		[Export ("reachableOnWWAN")]
		bool ReachableOnWWAN { get; set; }

		// +(SEGReachability * _Nullable)reachabilityWithHostname:(NSString * _Nonnull)hostname;
		[Static]
		[Export ("reachabilityWithHostname:")]
		[return: NullAllowed]
		SEGReachability ReachabilityWithHostname (string hostname);

		// +(SEGReachability * _Nullable)reachabilityForInternetConnection;
		[Static]
		[NullAllowed, Export ("reachabilityForInternetConnection")]
		[Verify (MethodToProperty)]
		SEGReachability ReachabilityForInternetConnection { get; }

		// +(SEGReachability * _Nullable)reachabilityForLocalWiFi;
		[Static]
		[NullAllowed, Export ("reachabilityForLocalWiFi")]
		[Verify (MethodToProperty)]
		SEGReachability ReachabilityForLocalWiFi { get; }

		// -(SEGReachability * _Nonnull)initWithReachabilityRef:(SCNetworkReachabilityRef _Nonnull)ref;
		[Export ("initWithReachabilityRef:")]
		unsafe NativeHandle Constructor (SCNetworkReachabilityRef* @ref);

		// -(BOOL)startNotifier;
		[Export ("startNotifier")]
		[Verify (MethodToProperty)]
		bool StartNotifier { get; }

		// -(void)stopNotifier;
		[Export ("stopNotifier")]
		void StopNotifier ();

		// -(BOOL)isReachable;
		[Export ("isReachable")]
		[Verify (MethodToProperty)]
		bool IsReachable { get; }

		// -(BOOL)isReachableViaWWAN;
		[Export ("isReachableViaWWAN")]
		[Verify (MethodToProperty)]
		bool IsReachableViaWWAN { get; }

		// -(BOOL)isReachableViaWiFi;
		[Export ("isReachableViaWiFi")]
		[Verify (MethodToProperty)]
		bool IsReachableViaWiFi { get; }

		// -(BOOL)isConnectionRequired;
		[Export ("isConnectionRequired")]
		[Verify (MethodToProperty)]
		bool IsConnectionRequired { get; }

		// -(BOOL)connectionRequired;
		[Export ("connectionRequired")]
		[Verify (MethodToProperty)]
		bool ConnectionRequired { get; }

		// -(BOOL)isConnectionOnDemand;
		[Export ("isConnectionOnDemand")]
		[Verify (MethodToProperty)]
		bool IsConnectionOnDemand { get; }

		// -(BOOL)isInterventionRequired;
		[Export ("isInterventionRequired")]
		[Verify (MethodToProperty)]
		bool IsInterventionRequired { get; }

		// -(SEGNetworkStatus)currentReachabilityStatus;
		[Export ("currentReachabilityStatus")]
		[Verify (MethodToProperty)]
		SEGNetworkStatus CurrentReachabilityStatus { get; }

		// -(SCNetworkReachabilityFlags)reachabilityFlags;
		[Export ("reachabilityFlags")]
		[Verify (MethodToProperty)]
		SCNetworkReachabilityFlags ReachabilityFlags { get; }

		// -(NSString * _Nonnull)currentReachabilityString;
		[Export ("currentReachabilityString")]
		[Verify (MethodToProperty)]
		string CurrentReachabilityString { get; }

		// -(NSString * _Nonnull)currentReachabilityFlags;
		[Export ("currentReachabilityFlags")]
		[Verify (MethodToProperty)]
		string CurrentReachabilityFlags { get; }
	}
}
