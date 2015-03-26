<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model app\models\Zakup */

$this->title = 'Create Zakup';
$this->params['breadcrumbs'][] = ['label' => 'Zakups', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="zakup-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
