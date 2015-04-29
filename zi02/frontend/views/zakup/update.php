<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Zakup */

$this->title = 'Zmień zakup: ' . ' ' . $model->id;
$this->params['breadcrumbs'][] = ['label' => 'Zakupy', 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->id, 'url' => ['view', 'id' => $model->id]];
$this->params['breadcrumbs'][] = 'Zmień';
?>
<div class="zakup-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'klienci' => $klienci,
    ]) ?>

</div>
