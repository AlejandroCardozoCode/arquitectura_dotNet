package controladorServicios;

import java.security.KeyManagementException;
import java.security.NoSuchAlgorithmException;
import java.security.cert.CertificateException;
import java.security.cert.X509Certificate;

import javax.net.ssl.SSLContext;
import javax.net.ssl.TrustManager;
import javax.net.ssl.X509TrustManager;

public class CreadorSSL {
	 
	static SSLContext insecureContext() {
	    TrustManager[] noopTrustManager = new TrustManager[]{
	        new X509TrustManager() {
	            public void checkClientTrusted1(X509Certificate[] xcs, String string) {}
	            public void checkServerTrusted1(X509Certificate[] xcs, String string) {}
	            public X509Certificate[] getAcceptedIssuers1() {
	                return null;
	            }
				@Override
				public void checkClientTrusted(X509Certificate[] chain, String authType) throws CertificateException {
					// TODO Auto-generated method stub
					
				}
				@Override
				public void checkServerTrusted(X509Certificate[] chain, String authType) throws CertificateException {
					// TODO Auto-generated method stub
					
				}
				@Override
				public X509Certificate[] getAcceptedIssuers() {
					// TODO Auto-generated method stub
					return null;
				}
	        }
	    };
	    try {
	        SSLContext sc = SSLContext.getInstance("ssl");
	        sc.init(null, noopTrustManager, null);
	        return sc;
	    } catch (KeyManagementException | NoSuchAlgorithmException ex) {}
		return null;
	}    	
}
