ASSEMBLY = esyplay
TARGET = exe
LINK = $(REF_DEP_LONGOMATCH)

SOURCES = \
	AssemblyInfo.cs \
	Main.cs

IMAGES = $(top_srcdir)/images/logo.svg \
         $(top_srcdir)/images/background.png

LOGO_48 = $(top_srcdir)/images/48x48/esyplay.png

bin_SCRIPTS = esyplay

DESKTOP_FILE = esyplay.desktop.in

include $(top_srcdir)/build/build.mk

EXTRA_DIST += \
	longomatch.in\
	AssemblyInfo.cs.in

