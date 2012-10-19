ASSEMBLY = EsyPlayImport
TARGET = library

LINK = $(REF_DEP_LONGOMATCH_CORE)\
       $(REF_DEP_LONGOMATCH_ADDINS)\
       $(LINK_LONGOMATCH_ADDINS)


SOURCES = \
	Assembly.cs \
	EsyPlayImport.cs

INSTALL_DIR := $(pkglibdir)/plugins
include $(top_srcdir)/build/build.mk

