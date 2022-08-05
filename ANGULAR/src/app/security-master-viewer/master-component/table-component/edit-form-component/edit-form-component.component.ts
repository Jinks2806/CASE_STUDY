import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators } from '@angular/forms';


@Component({
  selector: 'app-edit-form-component',
  templateUrl: './edit-form-component.component.html',
  styleUrls: ['./edit-form-component.component.scss']
})
export class EditFormComponentComponent implements OnInit {
  
  registerForm = new FormGroup({
    name: new FormControl('', [Validators.pattern(/\s/), Validators.required]),
    email: new FormControl('', [Validators.required, Validators.email]),
  });
  constructor() { }

  ngOnInit(): void {
  }
  onSubmit(): void {
    // display some fireworks
  }

}
