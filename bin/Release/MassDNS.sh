#!/bin/bash 
export DYLD_FALLBACK_LIBRARY_PATH="/Library/Frameworks/Mono.framework/Versions/Current/lib:/usr/local/lib:/usr/lib"
mono MassDNS.exe "$@"
