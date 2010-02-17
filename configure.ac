AC_INIT(README)
AC_CANONICAL_SYSTEM
AM_CONFIG_HEADER(config.h)
AM_INIT_AUTOMAKE(cpg-network-sharp, 1.0)
AM_MAINTAINER_MODE

AC_CONFIG_MACRO_DIR([m4])

AC_PROG_INSTALL
AM_PROG_LIBTOOL

AC_PATH_PROG(PKG_CONFIG, pkg-config, no)
if test "x$PKG_CONFIG" = "xno"; then
	AC_MSG_ERROR([You need to install pkg-config])
fi

# If you change these, update the error text below.
PKG_CHECK_MODULES(CPG_NETWORK, \
	cpg-network-1.0
)

AC_SUBST(CPG_NETWORK_LIBS)
AC_SUBST(CPG_NETWORK_CFLAGS)

PKG_CHECK_MODULES(MONO, mono >= 1.0.0)

AC_PATH_PROG(CSC, gmcs, no)
if test "x$CSC" = "xno"; then
	AC_MSG_ERROR([Your mono installation doesn't expose gmcs])
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

AC_SUBST(CSC)
AC_SUBST(GACUTIL)
AC_SUBST(LIB_PREFIX)
AC_SUBST(LIB_SUFFIX)

AC_PATH_PROG(GAPI_CODEGEN, gapi2-codegen, no)
AC_PATH_PROG(GAPI_FIXUP, gapi2-fixup, no)

PKG_CHECK_MODULES(GLIB_SHARP, \
	glib-sharp-2.0
)

AC_SUBST(GLIB_SHARP_LIBS)

API_VERSION=1.0.0.0
AC_SUBST(API_VERSION)

AC_OUTPUT([
cpg-network/Makefile
cpg-network/AssemblyInfo.cs
cpg-network-sharp.pc
Makefile
])

echo "---"
echo "Configuration successful."
echo "---"
