package com.engineer4myanmar.intakebook;



import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.AdapterView.OnItemClickListener;
import android.support.v4.app.NavUtils;
import android.text.Editable;
import android.text.TextWatcher;

public class CadetIBookBYNListActivity extends Activity {
	int iPosition=0;
	String sTitle="ဘုရင္႔ေနာင္တပ္ခြဲ(၁)";
	String sQuery;
	ListView lstBNY;
	SQLiteConnector sqlConnect;
	private static final String TABLE_RECORD = "cadettb";
	public final static String EXTRA_MESSAGE_BYN="com.engineer4myanmar.intakebook.BYNDETAIL";
	public String selectQueryb1 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၁)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	public String selectQueryb2 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၂)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	public String selectQueryb3 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၃)တပ္ခြဲ' and (bat='ဘုရင့္ေနာင္တပ္ရင္း' or bat='ဘုရင္႔ေနာင္တပ္ရင္း')" ;
	public String selectQueryb4 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၄)တပ္ခြဲ' and (bat='ဘုရင့္ေနာင္တပ္ရင္း' or bat='ဘုရင္႔ေနာင္တပ္ရင္း')" ;
	public String selectQueryb5 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၅)တပ္ခြဲ' and (bat='ဘုရင့္ေနာင္တပ္ရင္း' or bat='ဘုရင္႔ေနာင္တပ္ရင္း')" ;
	//public String selectQueryb6 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၆)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	//public String selectQueryb7 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၇)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	//public String selectQueryb8 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၈)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
        WindowManager.LayoutParams.FLAG_FULLSCREEN);
        Intent intent = getIntent();
        iPosition = intent.getIntExtra(CadetIBookBYNActivity.EXTRA_MESSAGE_BYN,0);        
        setContentView(R.layout.activity_cadet_ibook_bynlist);
        TextView tvTitle = (TextView)findViewById(R.id.tvTitle );
        
        switch(iPosition+1)
        {
        	case 1: 		sTitle="ဘုရင္႔ေနာင္တပ္ခြဲ(၁)"; sQuery=selectQueryb1; break;
        	case 2:		sTitle="ဘုရင္႔ေနာင္တပ္ခြဲ(၂)"; sQuery=selectQueryb2; break;
        	case 3:		sTitle="ဘုရင္႔ေနာင္တပ္ခြဲ(၃)"; sQuery=selectQueryb3; break;
        	case 4:		sTitle="ဘုရင္႔ေနာင္တပ္ခြဲ(၄)"; sQuery=selectQueryb4; break;
        	case 5:		sTitle="ဘုရင္႔ေနာင္တပ္ခြဲ(၅)"; sQuery=selectQueryb5; break;
        	//case 6:		sTitle="ဘုရင္႔ေနာင္တပ္ခြဲ(၆)"; sQuery=selectQueryb6; break;
        	//case 7:		sTitle="ဘုရင္႔ေနာင္တပ္ခြဲ(၇)"; sQuery=selectQueryb7; break;
        	//case 8:		sTitle="ဘုရင္႔ေနာင္တပ္ခြဲ(၈)"; sQuery=selectQueryb8; break;
        	default: 	sTitle="ဘုရင္႔ေနာင္တပ္ခြဲ(၁)"; sQuery=selectQueryb1; break;
        		
        }
        
        	tvTitle.setText(sTitle);
        	lstBNY = (ListView) findViewById(R.id.lstBYN);		
      		sqlConnect = new SQLiteConnector(this);
      		//collect all names
      		final ArrayAdapter<String> adapter2 = new ArrayAdapter<String>(this,
      				android.R.layout.simple_list_item_1, sqlConnect.getGroupRecord(2, sQuery));//getAllRecord(2)); // 2 is column number (zero base)
      		if(adapter2.isEmpty())
      		{
      			Log.e("empty","no data");
      		}
      		lstBNY.setAdapter(adapter2);		
      		
      		//Searchable EditText and ListView pair
      		EditText inputSearch = (EditText)findViewById(R.id.txtSearch );
      		inputSearch.addTextChangedListener(new TextWatcher() {		     
      		    public void onTextChanged(CharSequence cs, int arg1, int arg2, int arg3) {
      		        // When user changed the Text
      		    	adapter2.getFilter().filter(cs);		        
      		    }
      		    
      		    public void beforeTextChanged(CharSequence arg0, int arg1, int arg2,
      		            int arg3) {
      		        // TODO Auto-generated method stub		         
      		    }
      		     
      		    public void afterTextChanged(Editable arg0) {
      		        // TODO Auto-generated method stub                         
      		    }
      		});
      		
      		lstBNY.setOnItemClickListener(new OnItemClickListener() {
      			  public void onItemClick(AdapterView<?> parent, View view,
      			    int position, long id) {
      			    //Toast.makeText(getApplicationContext(),
      			    // position+ "  -  "+ ((TextView) view).getText(), Toast.LENGTH_LONG)
      			    //  .show();
      			    Intent myIntent = new Intent(CadetIBookBYNListActivity.this ,CadetIBookBYNDetailActivity.class);		
      				myIntent.putExtra(EXTRA_MESSAGE_BYN,((TextView) view).getText());
      				startActivity(myIntent);
      			  }
      			}); 		
      	}
    
    public void funHome(View v)
    {
    	startActivity(new Intent(CadetIBookBYNListActivity.this,CadetIBookMainActivity.class));   
    	CadetIBookBYNListActivity.this.finish();
    }
    
    @Override
    public void onBackPressed() {
       Log.d("CDA", "onBackPressed Called");
       startActivity(new Intent(CadetIBookBYNListActivity.this,CadetIBookBYNActivity.class));   
   		CadetIBookBYNListActivity.this.finish();
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
