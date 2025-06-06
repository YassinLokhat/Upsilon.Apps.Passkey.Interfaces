cmake_minimum_required(VERSION 3.14)
project(Interfaces LANGUAGES CSharp)

# Main library project
file(GLOB_RECURSE SRC_FILES 
    "${CMAKE_CURRENT_SOURCE_DIR}/*.cs"
)
file(GLOB_RECURSE EXCLUDED_FILES
    "${CMAKE_CURRENT_SOURCE_DIR}/obj/*"
    "${CMAKE_CURRENT_SOURCE_DIR}/bin/*"
)
if(EXCLUDED_FILES)
    list(REMOVE_ITEM SRC_FILES ${EXCLUDED_FILES})
endif()

add_library(Interfaces SHARED
    ${SRC_FILES}
)

# Set properties for the library
set_target_properties(Interfaces PROPERTIES
    DOTNET_SDK "${CMAKE_DOTNET_SDK}"
    DOTNET_TARGET_FRAMEWORK "${CMAKE_DOTNET_TARGET_FRAMEWORK}"
	
	VS_GLOBAL_ImplicitUsings "enable"
	VS_GLOBAL_Nullable "enable"
	VS_GLOBAL_Title "$(AssemblyName)"
	VS_GLOBAL_Authors "Yassin Lokhat"
	VS_GLOBAL_Configurations "Debug;Release"
	VS_GLOBAL_Description "A local stored Password Manager Interfaces."
	VS_GLOBAL_Version "1.0.0"
	VS_GLOBAL_TreatWarningsAsErrors "True"
	VS_GLOBAL_WarningLevel "9999"
)
