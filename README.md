# OpenTelemetryInHostedService
Example how to use OT Metrics in ASP.NET App

Current implementation contains example how to inject mesuring time metric to the Hosted service and export this data to the Console exporter.

Other examples will be added later.

```
Activity.TraceId:          207d0de81d6f0807db0c6b5f865ff8b7
Activity.SpanId:           f20c6e645e42c4af
Activity.TraceFlags:           Recorded
Activity.ActivitySourceName: OTExample
Activity.DisplayName: DoWorkAsync
Activity.Kind:        Internal
Activity.StartTime:   2022-08-04T16:57:14.3948853Z
Activity.Duration:    00:00:04.5427638
Resource associated with Activity:
    service.name: OTExample
    service.instance.id: b51a7236-9c7d-4b41-8ced-9b0ea92bd7b6
```
