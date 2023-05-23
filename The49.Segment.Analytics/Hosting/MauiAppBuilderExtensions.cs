using Microsoft.Maui.LifecycleEvents;

namespace The49.Segment.Analytics;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder UseAnalytics(this MauiAppBuilder builder, string writeKey)
    {
        return UseAnalytics(builder, writeKey, null);
    }

    public static MauiAppBuilder UseAnalytics(this MauiAppBuilder builder, string writeKey, Action<IAnalyticsBuilder>? configureDelegate)
    {
        builder.ConfigureLifecycleEvents(lifecycles =>
        {
#if ANDROID
            lifecycles.AddAndroid(androidLifecycle =>
            {
                androidLifecycle.OnApplicationCreate(application =>
                {
                    if (application is IPlatformApplication platformApplication)
                    {
                        var analyticsRegistration = platformApplication.Services.GetService<AnalyticsRegistration>();
                        var analytics = platformApplication.Services.GetService<IAnalytics>();

                        var analyticsBuilder = new AnalyticsBuilder(application.ApplicationContext, writeKey);

                        if (analyticsRegistration is not null)
                        {
                            analyticsRegistration.Build(analyticsBuilder);
                        }
                        if (analytics is Analytics a)
                        {
                            a.Setup(analyticsBuilder);
                        }
                    }
                });
            });
#elif IOS
            lifecycles.AddiOS(iOSLifecycle =>
            {
                iOSLifecycle.FinishedLaunching((application, launchOptions) =>
                {
                    if (application.Delegate is IPlatformApplication platformApplication)
                    {
                        var analyticsRegistration = platformApplication.Services.GetService<AnalyticsRegistration>();

                        var analyticsBuilder = new AnalyticsBuilder(writeKey);
                        if (analyticsRegistration is not null)
                        {
                            analyticsRegistration.Build(analyticsBuilder);
                        }
                        analyticsBuilder.Build();
                    }
                    return true;
                });
            });
#endif
        });
        UseAnalytics(builder.Services, configureDelegate);
        return builder;
    }

    public static IServiceCollection UseAnalytics(this IServiceCollection services, Action<IAnalyticsBuilder>? configureDelegate)
    {
        services.AddSingleton<IAnalytics, Analytics>();
        if (configureDelegate != null)
        {
            services.AddSingleton(new AnalyticsRegistration(configureDelegate));
        }

        return services;
    }

    internal class AnalyticsRegistration
    {
        private readonly Action<IAnalyticsBuilder> _registerAction;

        public AnalyticsRegistration(Action<IAnalyticsBuilder> registerAction)
        {
            _registerAction = registerAction;
        }

        internal void Build(IAnalyticsBuilder builder)
        {
            _registerAction(builder);
        }
    }
}
