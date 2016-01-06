package com.swp.knowledge;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import android.os.Bundle;
import android.annotation.TargetApi;
import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;
import android.support.v4.app.NavUtils;

public class AirActivity extends Activity {
	public final static String EXTRA_MESSAGE_AIR = "com.engineer4myanmar.swp.knowledge.AIR";

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
		setContentView(R.layout.activity_air);

		final ListView listview = (ListView) findViewById(R.id.listview);
		String[] values = new String[] { 
				"မာတိကာ", //1
				"အဓိပၸါယ္ဖြင္႔", //2
				"ေလေၾကာင္းရန္ ကာကြယ္ေရး အမ်ိဳးအစားမ်ား", //3
				"ခံစစ္အသြင္ ေလေၾကာင္းရန္ ကာကြယ္ေရး", //4
				"တန္ျပန္ေလေၾကာင္းရန္ ကာကြယ္ေရး", //5
				"ငုတ္လ်ိဳး ေလေၾကာင္းရန္ ကာကြယ္ေရး", //6
				"ထိုးစစ္အသြင္ ေလေၾကာင္းရန္ ကာကြယ္ေရး", //7   20 သံုးမယ္
				"ခံစစ္အသြင္ ေလေၾကာင္းရန္ ကာကြယ္ေရး ကာကြယ္ရမည္႔ေနရာမ်ား", //8
				"ေလေၾကာင္းရန္ ကာကြယ္ေရး၏ ရည္မွန္းခ်က္", //9
				"ေလေၾကာင္းရန္ ကာကြယ္ေရး၏ လိုအပ္ခ်က္ (ဥပေဒသမ်ား) ၁", //10
				"ေလေၾကာင္းရန္ ကာကြယ္ေရး၏ လိုအပ္ခ်က္ (ဥပေဒသမ်ား) ၂", //11
				"ေလေၾကာင္းရန္ ကာကြယ္ေရး၏ လိုအပ္ခ်က္ (ဥပေဒသမ်ား) ၃", //12
				"ေလေၾကာင္းရန္ ကာကြယ္ေရး၏ အဆင္႔မ်ား", //13 (14-15) to del
				"နည္းဗ်ဴဟာေျမာက္ လွည္႔စားမႈ", //14 16
				"မ်က္ျမင္မွ ဖံုးကြယ္နည္း",//15 17
				"အတုျဖင္႔ ပံုမွားရိုက္ျခင္း",//16 18
				"ေရဒါေထာက္လွမ္းမႈကို လွည္႔စားျခင္း", //17 19
				"ထိုးစစ္အသြင္ ေလေၾကာင္းရန္ ကာကြယ္ေရး၏ လက္နက္မ်ား", //18 21
				"ေလေၾကာင္းရန္ ကာကြယ္ေရး စနစ္ႏွစ္ခု၏ ဆက္စပ္မႈ", //19 22
				"က်မ္းကိုးစာရင္း"//20 23
				 };

		final ArrayList<String> list = new ArrayList<String>();
		for (int i = 0; i < values.length; ++i) {
			list.add(values[i]);
		}
		final StableArrayAdapter adapter = new StableArrayAdapter(this,
				android.R.layout.simple_list_item_1, list);
		listview.setAdapter(adapter);

		listview.setOnItemClickListener(new AdapterView.OnItemClickListener() {

			@TargetApi(16)
			public void onItemClick(AdapterView<?> parent, final View view,
					int position, long id) {
				final String item = (String) parent.getItemAtPosition(position);
				Toast.makeText(getApplicationContext(), item,
						Toast.LENGTH_SHORT).show();
				Intent AirDetailIntent = new Intent(AirActivity.this,
						AirDetialActivity.class);
				AirDetailIntent.putExtra(EXTRA_MESSAGE_AIR, position);
				startActivity(AirDetailIntent);

				// great animation to delete items
				// view.animate().setDuration(2000).alpha(0)
				// .withEndAction(new Runnable() {
				// public void run() {
				// list.remove(item);
				// adapter.notifyDataSetChanged();
				// view.setAlpha(1);
				// }
				// });
			}

		});
	}

	private class StableArrayAdapter extends ArrayAdapter<String> {

		HashMap<String, Integer> mIdMap = new HashMap<String, Integer>();

		public StableArrayAdapter(Context context, int textViewResourceId,
				List<String> objects) {
			super(context, textViewResourceId, objects);
			for (int i = 0; i < objects.size(); ++i) {
				mIdMap.put(objects.get(i), i);
			}
		}

		public long getItemId(int position) {
			String item = getItem(position);
			return mIdMap.get(item);
		}

		public boolean hasStableIds() {
			return true;
		}

	}
}
