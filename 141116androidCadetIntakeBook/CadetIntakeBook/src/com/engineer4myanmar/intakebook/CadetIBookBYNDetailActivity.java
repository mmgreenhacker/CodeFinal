package com.engineer4myanmar.intakebook;
import android.net.Uri;
import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.widget.ArrayAdapter;
import android.widget.TextView;
import android.widget.ImageView;
import android.support.v4.app.NavUtils;

public class CadetIBookBYNDetailActivity extends Activity {
	String sPhoneNumber;
	SQLiteConnector sqlConnect;
	int x=0;
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
        WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_cadet_ibook_byndetail);
        Intent myIntent = getIntent();
        String sCadetName = myIntent.getStringExtra(CadetIBookBYNListActivity.EXTRA_MESSAGE_BYN);
        sqlConnect = new SQLiteConnector(this);
        TextView tvTitleDetail = (TextView)findViewById(R.id.tvTitleDetail );
        
        TextView etCdId = (TextView)findViewById(R.id.etCdId );
        TextView etCdName= (TextView)findViewById(R.id.etCdName );
        TextView etDir = (TextView)findViewById(R.id.etDir);
        TextView etPhone = (TextView)findViewById(R.id.etPhone);
        TextView etFb = (TextView)findViewById(R.id.etFb);
        TextView etMaj = (TextView)findViewById(R.id.etMaj);
        TextView etAddress= (TextView)findViewById(R.id.etAddress);
        TextView etCom = (TextView)findViewById(R.id.etCom);
        TextView etBat = (TextView)findViewById(R.id.etBat);
        
        ImageView imgPhoto=(ImageView)findViewById(R.id.imgPhoto );
        final ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(1));
        final ArrayAdapter<String> adapter1 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(2));
        final ArrayAdapter<String> adapter2 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(3));
        final ArrayAdapter<String> adapter3 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(4));
        final ArrayAdapter<String> adapter4 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(5));
        final ArrayAdapter<String> adapter5 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(6));
        final ArrayAdapter<String> adapter6 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(7));
        final ArrayAdapter<String> adapter7 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(8));
        final ArrayAdapter<String> adapter8 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(9));
        final ArrayAdapter<String> adapter9 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(10));
        System.out.println(adapter8.getItem(adapter1.getPosition(sCadetName)));
        System.out.println("adapters OK");
       
       int j = getResources().getIdentifier(adapter9.getItem(adapter1.getPosition(sCadetName)).toLowerCase(), "drawable", getPackageName());
       imgPhoto.setImageDrawable(getResources().getDrawable(j));     
        System.out.println("Photo OK");
        tvTitleDetail.setText(sCadetName);
        System.out.println("Title OK");
        etCdId.setText(adapter.getItem(adapter1.getPosition(sCadetName)));
        etCdName.setText(adapter1.getItem(adapter1.getPosition(sCadetName)));
        etDir.setText(adapter2.getItem(adapter1.getPosition(sCadetName)));
        etPhone.setText(adapter3.getItem(adapter1.getPosition(sCadetName)));
        sPhoneNumber = adapter3.getItem(adapter1.getPosition(sCadetName));
        etFb.setText(adapter4.getItem(adapter1.getPosition(sCadetName)));
        etMaj.setText(adapter5.getItem(adapter1.getPosition(sCadetName)));
        etAddress.setText(adapter6.getItem(adapter1.getPosition(sCadetName)));
        etCom.setText(adapter7.getItem(adapter1.getPosition(sCadetName)));
        etBat.setText(adapter8.getItem(adapter1.getPosition(sCadetName)));
        System.out.println(adapter8.getItem(adapter1.getPosition(sCadetName)));
        
     
    }
    public void funHome(View v)
    {
    	startActivity(new Intent(CadetIBookBYNDetailActivity.this,CadetIBookMainActivity.class));   
    	CadetIBookBYNDetailActivity.this.finish();
    }
    public void funCallHim(View v)
    {
    	Intent callIntent = new Intent(Intent.ACTION_CALL);//CALL-DIAL
		callIntent.setData(Uri.parse("tel:"+sPhoneNumber));    
		startActivity(callIntent);
    }
    public void funBluePhoenix(View v)
    {
    	WebView webView = (WebView) findViewById(R.id.webview1);
        WebSettings settings = webView.getSettings();
        settings.setJavaScriptEnabled(true);
        String URL="http://www.engineer4myanmar.com";
		webView.loadUrl(URL);
        settings.setSupportZoom(true);
        settings.setBuiltInZoomControls(true);
    }
}
