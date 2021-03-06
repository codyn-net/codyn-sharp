AC_INIT([codyn3-sharp], [3.6])
AC_CANONICAL_SYSTEM
AC_CONFIG_HEADERS([config.h])
AM_INIT_AUTOMAKE([1.11 tar-ustar dist-xz no-dist-gzip -Wno-portability])
AM_MAINTAINER_MODE

AC_CONFIG_MACRO_DIR([m4])

AC_PROG_INSTALL
AM_PROG_LIBTOOL

AC_PATH_PROG(PKG_CONFIG, pkg-config, no)
if test "x$PKG_CONFIG" = "xno"; then
	AC_MSG_ERROR([You need to install pkg-config])
fi

# If you change these, update the error text below.
AC_PATH_PROGS(CSC, dmcs gmcs, no)

if test "x$CSC" = "xno"; then
	AC_MSG_ERROR([Your mono installation doesn't expose dmcs or gmcs])
fi

AC_PATH_PROG(GACUTIL, gacutil, no)
if test "x$GACUTIL" = "xno"; then
	AC_MSG_ERROR([Your mono installation doesn't expose gacutil])
fi

if test `uname -s` = "Darwin"; then
	LIB_PREFIX=
	LIB_SUFFIX=.dylib
else
	LIB_PREFIX=.so
	LIB_SUFFIX=
fi

AC_ARG_ENABLE([release], [Build release (default no)], [enable_release=$enableval], [enable_release=no])

AM_CONDITIONAL([ENABLE_RELEASE], [test x$enable_release != xno])
AM_CONDITIONAL([ENABLE_DEBUG], [test x$enable_release = xno])

AC_SUBST(CSC)
AC_SUBST(GACUTIL)
AC_SUBST(LIB_PREFIX)
AC_SUBST(LIB_SUFFIX)

AC_PATH_PROG(GAPI_CODEGEN, gapi2-codegen, no)
AC_PATH_PROG(GAPI_FIXUP, gapi2-fixup, no)

AM_CONDITIONAL(HAS_GAPI_CODEGEN, test "x$GAPI_CODEGEN" != "xno")
AM_CONDITIONAL(HAS_GAPI_FIXUP, test "x$GAPI_FIXUP" != "xno")

PKG_CHECK_MODULES(GLIB_SHARP, \
	glib-sharp-2.0
)

AC_SUBST(GLIB_SHARP_LIBS)

CODYN_SHARP_API_VERSION=3.0
AC_SUBST(CODYN_SHARP_API_VERSION)

API_VERSION=3.0.0.0
AC_SUBST(API_VERSION)

AC_OUTPUT([
codyn/Makefile
codyn/AssemblyInfo.cs
codyn-sharp.pc
Makefile
])

echo "---"
echo "Configuration successful."
echo "---"
