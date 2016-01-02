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

public class CadetIBookANYDetailActivity extends Activity {
	SQLiteConnector sqlConnect;
	String  sPhoneNumber;
	int x=0;
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
        WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_cadet_ibook_byndetail);
        System.out.println("load ok");
        Intent myIntent = getIntent();
        String sCadetName = myIntent.getStringExtra(CadetIBookANYListActivity.EXTRA_MESSAGE_ANYDETAIL);
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
        System.out.println("adapters1 OK");
        
        final ArrayAdapter<String> adapter1 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(2));
        System.out.println("adapters2 OK");
        System.out.println(adapter.getItem(adapter1.getPosition(sCadetName)));
        final ArrayAdapter<String> adapter2 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(3));
        System.out.println("adapters3 OK");
        System.out.println(adapter1.getItem(adapter1.getPosition(sCadetName)));
        final ArrayAdapter<String> adapter3 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(4));
        System.out.println("adapters4 OK");
        System.out.println(adapter2.getItem(adapter1.getPosition(sCadetName)));
        final ArrayAdapter<String> adapter4 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(5));
        System.out.println("adapters4 OK");
        System.out.println(adapter3.getItem(adapter1.getPosition(sCadetName)));
        final ArrayAdapter<String> adapter5 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(6));
        System.out.println("adapters5 OK");
        System.out.println(adapter4.getItem(adapter1.getPosition(sCadetName)));
        final ArrayAdapter<String> adapter6 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(7));
        System.out.println("adapters6 OK");
        System.out.println(adapter5.getItem(adapter1.getPosition(sCadetName)));
        final ArrayAdapter<String> adapter7 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(8));
        System.out.println("adapters7 OK");
        System.out.println(adapter6.getItem(adapter1.getPosition(sCadetName)));
        final ArrayAdapter<String> adapter8 = new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(9));
        System.out.println("adapters8 OK");
        System.out.println(adapter7.getItem(adapter1.getPosition(sCadetName)));
        System.out.println(adapter8.getItem(adapter1.getPosition(sCadetName)));
       // final ArrayAdapter<String> adapter9 = new ArrayAdapter<String>(this,
		//		android.R.layout.simple_list_item_1, sqlConnect.getAllRecord(10));
        System.out.println(adapter8.getItem(adapter1.getPosition(sCadetName)));
        System.out.println("adapters OK");
       
       // int j = getResources().getIdentifier(adapter8.getItem(adapter1.getPosition(sCadetName)).toLowerCase(), "drawable", getPackageName());
        //System.out.println(j);
        //System.out.println(getResources().getDrawable(j));
        //imgPhoto.setImageDrawable(getResources().getDrawable(j));     
        //System.out.println(j);
        //System.out.println(getResources().getDrawable(j));
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
    	startActivity(new Intent(CadetIBookANYDetailActivity.this,CadetIBookMainActivity.class));   
    	CadetIBookANYDetailActivity.this.finish();
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
