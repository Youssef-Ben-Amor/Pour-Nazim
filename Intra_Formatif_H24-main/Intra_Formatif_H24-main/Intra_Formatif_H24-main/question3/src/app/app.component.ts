import { Component } from '@angular/core';
import { AbstractControl, FormBuilder, ValidationErrors, Validators, ReactiveFormsModule, FormGroup } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { CommonModule } from '@angular/common';

interface Data {
  name?: string | null,
  roadnumber?: number | null,
  road?: string | null,
  postalcode?: string | null,
  comments?: string | null
}
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  standalone: true,
  imports: [MatToolbarModule, MatIconModule, MatCardModule, ReactiveFormsModule, MatFormFieldModule, MatInputModule, MatButtonModule, CommonModule]
})
export class AppComponent {
  title = 'reactive.form';

  form: FormGroup<any>;
  formData: Data | null = null;
  constructor(private fb: FormBuilder

  ) {
    this.form = this.fb.group({
      name: ['', Validators.required],
      roadnumber: ['', [Validators.required, Validators.max(9999), Validators.min(1000)]],
      road: ['', Validators.required],
      postalcode: ['', Validators.pattern("^[A-Z][0-9][A-Z][ ]?[0-9][A-Z][0-9]$")],
      comments: ['', this.commentLenghtValidator]
    })
    this.form.valueChanges.subscribe(() => {
      this.formData = this.form.value;
    });
  }

  commentLenghtValidator(control: AbstractControl): ValidationErrors | null {
    const comments = control.get('comments')?.value;

    if (comments && comments.split(" ").length >= 10) {
      return { commentValidator: true }
    }
    return null
  }
}


