package com.engineer4myanmar.intakebook;



import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

public class Custom_view extends ArrayAdapter<String> {

	private final Context context;
	private final String[] values;
	int[] imageIDs = {
			R.drawable.dsta,			R.drawable.dsta,	
			R.drawable.dsta,			R.drawable.dsta,	
			R.drawable.dsta,			R.drawable.dsta,	
			R.drawable.dsta,			R.drawable.dsta,	
			R.drawable.dsta,			R.drawable.dsta
			
	};
	public Custom_view(Context context, String[] values) {
		super(context, R.layout.teacher_list_activity, values);
		this.context = context;
		this.values = values;
	}

	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		// TODO Auto-generated method stub
		LayoutInflater inflater = (LayoutInflater) context
				.getSystemService(Context.LAYOUT_INFLATER_SERVICE);

		View rowView = inflater.inflate(R.layout.teacher_list_activity, parent, false);
		TextView tv = (TextView) rowView.findViewById(R.id.tvTeacher);
		ImageView iv = (ImageView) rowView.findViewById(R.id.list_image);

		String item_value = values[position];
		iv.setImageResource(imageIDs[position]);
		tv.setText(item_value);
		

		return rowView;
	}

}
