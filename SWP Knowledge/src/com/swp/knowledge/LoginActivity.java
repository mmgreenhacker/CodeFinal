package com.swp.knowledge;




import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.EditText;

public class LoginActivity extends Activity {

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
		setContentView(R.layout.activity_login);
	}

	public void funLogin(View v) {
		EditText etPassword = (EditText) findViewById(R.id.etPassword);
		String sPass = "";
		sPass = etPassword.getText().toString();
		//### password ကို ျပန္ထည္႔ခ်င္ရင္ ဒီ ကြန္မင္႔ကို ဖ်က္
		
		if (sPass.equals("30445")) {
			startActivity(new Intent(LoginActivity.this,
					MainActivity.class));
			LoginActivity.this.finish();
		}

	}
}
