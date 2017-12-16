#!/bin/bash

echo "Cleaning leftover tilde files from the editor"
/usr/bin/find . -name \*~ -print -exec rm {} \;

