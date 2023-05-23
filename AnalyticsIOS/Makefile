SEGMENT_BUILD_PATH := analytics-ios/build
SEGMENT_PROJECT_NAME := Segment
SEGMENT_PROJECT_PATH := analytics-ios/$(SEGMENT_PROJECT_NAME).xcodeproj
BINDINGS_PATH := Bindings
IOS_SDK_VERSION := 16.4

clean: clean-segment

build-segment: clean-segment
	xcodebuild -sdk iphonesimulator$(IOS_SDK_VERSION) -project "$(SEGMENT_PROJECT_PATH)" -configuration Release EXCLUDED_ARCHS="arm64" ENABLE_BITCODE=NO
	xcodebuild -sdk iphoneos$(IOS_SDK_VERSION) -project "$(SEGMENT_PROJECT_PATH)" -configuration Release ENABLE_BITCODE=NO

	cp -R "$(SEGMENT_BUILD_PATH)/Release-iphoneos" "$(SEGMENT_BUILD_PATH)/Release-fat"

	lipo -create "$(SEGMENT_BUILD_PATH)/Release-iphoneos/$(SEGMENT_PROJECT_NAME).framework/$(SEGMENT_PROJECT_NAME)" "$(SEGMENT_BUILD_PATH)/Release-iphonesimulator/$(SEGMENT_PROJECT_NAME).framework/$(SEGMENT_PROJECT_NAME)" -output "$(SEGMENT_BUILD_PATH)/Release-fat/$(SEGMENT_PROJECT_NAME).framework/$(SEGMENT_PROJECT_NAME)"

	cp -Rf "$(SEGMENT_BUILD_PATH)/Release-fat/$(SEGMENT_PROJECT_NAME).framework" "./"

clean-segment:
	xcodebuild clean -project "$(SEGMENT_PROJECT_PATH)"
	rm -Rf "./Frameworks/$(SEGMENT_PROJECT_NAME).framework"
	rm -Rf "$(SEGMENT_BUILD_PATH)"

build-bindings: clean-bindings
	sharpie bind --sdk=iphoneos$(IOS_SDK_VERSION) --output="$(BINDINGS_PATH)" --namespace="Segment" --scope="./Segment.framework/Headers" "./Segment.framework/Headers/Segment.h"
	
clean-bindings:
	rm -Rf $(BINDINGS_PATH)

build: build-segment build-bindings

.PHONY: clean build
